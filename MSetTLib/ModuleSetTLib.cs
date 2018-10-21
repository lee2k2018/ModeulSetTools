using LModBusRTU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZLSerialPortBusLib.PLCManager;




/// <summary>
/*--------------------------------------------------------------------------
 * PLC模块设置工具
 * 
 * 通用模块只会读取0x00-0x0F寄存器，各地址用途说明 
 * [0x00]       //< PLC Address；写入可以修改地址，必须计算专用SNKey
 * [0x01]       //< Last Error Code! No Used!；写入可以重启PLC
 * [0x02]       //< PLC SN 0    (PLC序列号共12个字节)
 * [0x03]       //< PLC SN 1
 * [0x04]       //< PLC SN 2
 * [0x05]       //< PLC SN 3
 * [0x06]       //< PLC SN 4
 * [0x07]       //< PLC SN 5
 * [0x08-0x09]  //< PLC RunTime CFG 数据大小，单位：uint16_t
 * [0x0A-0x0F]  //< PLC Config
 * 
--------------------------------------------------------------------------*/
/// </summary>
namespace MSetTLib
{
    public interface LModuleSetTool
    {
        void SetParent(Control fParent);
        void CloseAll();
        void ClearAll();
    }

    public class ModulePLCBase
    {
        public const int RegStar = 0;           // 寄存器起始地址
        public const int SystemRegCount = 0x20;       // 寄存器数量
        
        protected const int fRegIdx_PLCAddr = 0x00;
        protected const int fRegIdx_ErrorCode = 0x01;
        protected const int fRegIdx_PLCSN = 0x02;
        protected const int fRegIdx_RTCFGSizeH = 0x08;
        protected const int fRegIdx_RTCFGSizeL = 0x09;

        #region 外部功能应用 

        public bool PLCConnected
        {
            get
            {
                return PLCActive() && (fPLCModbusNode.PLCDisconnectCount < 5);
            }
        }

        public bool HasNewData
        {
            get
            {
                return PLCActive() && fPLCModbusNode.HasNewData;
            }
        }

        public int PLCAddress
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.PLCIPAddress0 : 0;
            }
            set
            {
                SetPLCAddress(value);
            }
        }

        public int RegistersCount { get { return PLCActive() ? fPLCModbusNode.RegCount : 0; } }
                     
        public int PLCErrorCode
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ErrorCode] : 0;
            }
        }
        /// <summary>
        /// PLC RunTime CFG 数据大小，单位：uint16_t
        /// </summary>
        public int PLCRTCFGSize
        {
            get
            {
                if (PLCActive())
                {
                    int fSize = fPLCModbusNode.RegValues[fRegIdx_RTCFGSizeH];
                    fSize <<= 8;
                    fSize |= fPLCModbusNode.RegValues[fRegIdx_RTCFGSizeL];
                    return fSize;
                }
                return 0;
            }
        }

        public string PLCSNStr
        {
            get
            {
                if (PLCActive())
                    return string.Format("{0:X2}{1:X2}{2:X2}{3:X2}{4:X2}{5:X2}{6:X2}{7:X2}{8:X2}{9:X2}{10:X2}{11:X2}",
                        ((fPLCModbusNode.RegValues[fRegIdx_PLCSN + 0] >> 8) & 0xFF),
                        (fPLCModbusNode.RegValues[fRegIdx_PLCSN + 0] & 0xFF),
                        ((fPLCModbusNode.RegValues[fRegIdx_PLCSN + 1] >> 8) & 0xFF),
                        (fPLCModbusNode.RegValues[fRegIdx_PLCSN + 1] & 0xFF),
                        ((fPLCModbusNode.RegValues[fRegIdx_PLCSN + 2] >> 8) & 0xFF),
                        (fPLCModbusNode.RegValues[fRegIdx_PLCSN + 2] & 0xFF),
                        ((fPLCModbusNode.RegValues[fRegIdx_PLCSN + 3] >> 8) & 0xFF),
                        (fPLCModbusNode.RegValues[fRegIdx_PLCSN + 3] & 0xFF),
                        ((fPLCModbusNode.RegValues[fRegIdx_PLCSN + 4] >> 8) & 0xFF),
                        (fPLCModbusNode.RegValues[fRegIdx_PLCSN + 4] & 0xFF),
                        ((fPLCModbusNode.RegValues[fRegIdx_PLCSN + 5] >> 8) & 0xFF),
                (fPLCModbusNode.RegValues[fRegIdx_PLCSN + 5] & 0xFF));
                return "";
            }
        }

        public byte[] PLCSNByte
        {
            get
            {
                byte[] fValue = new byte[12];
                if (!string.IsNullOrEmpty(PLCSNStr))
                {
                    for (int i = 0; i < 6; i++)
                    {
                        fValue[i * 2] = (byte)(fPLCModbusNode.RegValues[fRegIdx_PLCSN + i] & 0xFF);
                        fValue[i * 2 + 1] = (byte)((fPLCModbusNode.RegValues[fRegIdx_PLCSN + i] >> 8) & 0xFF);
                    }
                    return fValue;
                }
                return null;
            }
            set
            {
                SetPLCSN(value);
            }
        }

        public byte[] PLCSNByteLF
        {
            get
            {
                byte[] fValue = new byte[12];
                if (!string.IsNullOrEmpty(PLCSNStr))
                {
                    for (int i = 0; i < 6; i++)
                    {
                        fValue[i * 2 + 1] = (byte)(fPLCModbusNode.RegValues[fRegIdx_PLCSN + i] & 0xFF);
                        fValue[i * 2] = (byte)((fPLCModbusNode.RegValues[fRegIdx_PLCSN + i] >> 8) & 0xFF);
                    }
                    return fValue;
                }
                return null;
            }
        }


        /// <summary>
        /// 读取寄存器值
        /// </summary>
        /// <param name="fIndex"></param>
        /// <param name="fValue"></param>
        /// <returns></returns>
        public bool GetRegValue(int fIndex, out int fValue)
        {
            fValue = 0;
            if (PLCActive() && (fIndex >= 0) && (fIndex < fPLCModbusNode.RegCount))
            {
                fValue = fPLCModbusNode.RegValues[fIndex];
                return true;
            }
            return false;
        }

        public virtual bool PLCActive()
        {
                return (fPLCModbusNode != null)
                      && (fPLCModbusNode.PLCDisconnectCount < 5)
                      && (fPLCModbusNode.RegCount >= SystemRegCount);           
        }
        #endregion

        #region 内部属性及变量
        protected ZLPLCModbusNode fPLCModbusNode { get; set; }
        protected ZLPLCBusOnSerialPort fSerialPortBus { get; set; }
        #endregion

        #region 构建函数

        public ModulePLCBase(ZLPLCModbusNode fPLCModbusNodeX, ZLPLCBusOnSerialPort fSerialPortBusX)
        {
            fPLCModbusNode = fPLCModbusNodeX;
            fSerialPortBus = fSerialPortBusX;
        }

        public virtual void Close()
        {
            fPLCModbusNode = null;
            fSerialPortBus = null;
        }
        #endregion

        /// <summary>
        /// 将制定PLC的地址改为新的地址
        /// </summary>
        /// <param name="fOldPLCAddress">原PLC地址</param>
        /// <param name="fNewPLCAddress">新的PLC地址</param>
        public void SetPLCAddress(int fNewPLCAddress)
        {
            if (PLCActive() && (fSerialPortBus != null))
            {
                if (!string.IsNullOrEmpty(fPLCModbusNode.PLCSNStr))
                {
                    int[] fDataBuf = new int[] { CRC16_GB19582.CRC16GB(fPLCModbusNode.PLCSNByteLF, TCRC16Endian.Big),
                        fNewPLCAddress };   // 写入2个字节寄存器
                    TModbusRTUCommandV2 fCommand = new TModbusRTUCommandV2(ModbusCommand.WriteMemoryReg_0x10);
                    fCommand.PLCAddress = (byte)PLCAddress;
                    fCommand.RegWriteAddress = 0;       // 写入本机地址
                    fCommand.RegWriteCount = (ushort)fDataBuf.Length;
                    for (int i = 0; i < fDataBuf.Length; i++)
                        fCommand.RegValue[i] = (ushort)fDataBuf[i];
                    int fTimeOut = 100;
                    fSerialPortBus.SendModbusCommand(fCommand, ref fTimeOut);
                }
            }
            else
                throw new Exception("目标PLC无法操作！");
        }

        /// <summary>
        /// 写入PLC的序列号；
        /// </summary>
        /// <param name="fPLCSN"></param>
        /// <param name="fPLCAddress"></param>
        public void SetPLCSN(byte[] fPLCSN)
        {
            if (PLCActive() && (fSerialPortBus != null))
            {
                if ((fPLCSN != null) && (fPLCSN.Length == 12))
                {
                    List<ushort> fDataBuf = new List<ushort>();
                    fDataBuf.Add((ushort)CRC16_GB19582.CRC16GB(PLCSNByteLF, TCRC16Endian.Big));
                    // 将要写入的PLCSN放入，转换为ushort，高位在前，写入缓冲区
                    ushort fVTemp = 0;
                    for (int i = 0; i < fPLCSN.Length; i++)
                    {
                        if (i % 2 == 0)     //寄存器低位： 0,2,4,6,8,10,12
                            fVTemp = fPLCSN[i];
                        else
                        {       //寄存器高位： 1,3,5,7,9,11
                            ushort fVT1 = fPLCSN[i];
                            fVTemp <<= 8;
                            fVTemp |= fVT1;
                            fDataBuf.Add(fVTemp);
                            fVTemp = 0;
                        }
                    }
                    TModbusRTUCommandV2 fCommand = new TModbusRTUCommandV2(ModbusCommand.WriteMemoryReg_0x10);
                    fCommand.PLCAddress = (byte)this.PLCAddress;
                    fCommand.RegWriteAddress = 2;       // 写入PLCSN，不是所有PLC都能够写入PLCSN
                    fCommand.RegWriteCount = (ushort)fDataBuf.Count;
                    for (int i = 0; i < fDataBuf.Count; i++)
                        fCommand.RegValue[i] = fDataBuf[i];
                    int fTimeOut = 100;
                    fSerialPortBus.SendModbusCommand(fCommand, ref fTimeOut);
                }
            }
            else
                throw new Exception("目标PLC无法操作！");
        }
        /// <summary>
        /// 写入特殊寄存器值
        /// </summary>
        /// <param name="fRegIdx">寄存器地址序号</param>
        /// <param name="fADCSet">要设置的值</param>
        public void WriteSetReg(ushort fRegIdx, ushort fADCSet)
        {
            if (PLCActive() && (fSerialPortBus != null))
            {
                int[] fDataBuf = new int[] { CRC16_GB19582.CRC16GB(fPLCModbusNode.PLCSNByteLF, TCRC16Endian.Big),
                        fADCSet };   // 写入2个字节寄存器
                TModbusRTUCommandV2 fCommand = new TModbusRTUCommandV2(ModbusCommand.WriteMemoryReg_0x10);
                fCommand.PLCAddress = (byte)PLCAddress;
                fCommand.RegWriteAddress = fRegIdx;       // 写入本机地址
                fCommand.RegWriteCount = (ushort)fDataBuf.Length;
                for (int i = 0; i < fDataBuf.Length; i++)
                    fCommand.RegValue[i] = (ushort)fDataBuf[i];
                int fTimeOut = 100;
                fSerialPortBus.SendModbusCommand(fCommand, ref fTimeOut);
            }
        }
        /// <summary>
        /// 写入寄存器值
        /// </summary>
        /// <param name="fRegStar">目标寄存器起始地址</param>
        /// <param name="fRegValue">等待写入的数据</param>
        public void WriteReg(ushort fRegStar, ushort[] fRegValue)
        {
            if (PLCActive() && (fSerialPortBus != null))
            {
                TModbusRTUCommandV2 fCommand = new TModbusRTUCommandV2(ModbusCommand.WriteMemoryReg_0x10);
                fCommand.PLCAddress = (byte)PLCAddress;
                fCommand.RegWriteAddress = fRegStar;       // 写入本机地址
                fCommand.RegWriteCount = (ushort)fRegValue.Length;
                for (int i = 0; i < fRegValue.Length; i++)
                    fCommand.RegValue[i] = fRegValue[i];
                int fTimeOut = 100;
                fSerialPortBus.SendModbusCommand(fCommand, ref fTimeOut);
            }
        }
    }

}
