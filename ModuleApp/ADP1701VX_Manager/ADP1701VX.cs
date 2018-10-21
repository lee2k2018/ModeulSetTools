using LModBusRTU;
using MSetTLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZLSerialPortBusLib.PLCManager;

namespace ADP1701VX_Manager
{
    public class ADP1701VX : ModulePLCBase
    {
        public const int PLCRegCount = 0x60;       // 寄存器数量

        protected const int fRegIdx_ADICAResultCount = 0x10;
        protected const int fRegIdx_ADICAVRef = 0x11;
        protected const int fRegIdx_ADICA11 = 0x13;
        protected const int fRegIdx_ADICA12 = 0x15;
        protected const int fRegIdx_ADICA13 = 0x17;
        protected const int fRegIdx_ADICA14 = 0x19;
        protected const int fRegIdx_ADICA15 = 0x1B;
        protected const int fRegIdx_ADICA16 = 0x1D;
        protected const int fRegIdx_ADICA17 = 0x1F;

        protected const int fRegIdx_ADICBResultCount = 0x20;
        protected const int fRegIdx_ADICBVRef = 0x21;
        protected const int fRegIdx_ADICA21 = 0x23;
        protected const int fRegIdx_ADICA22 = 0x25;
        protected const int fRegIdx_ADICA23 = 0x27;
        protected const int fRegIdx_ADICA24 = 0x29;
        protected const int fRegIdx_ADICA25 = 0x2B;
        protected const int fRegIdx_ADICA26 = 0x2D;
        protected const int fRegIdx_ADICA27 = 0x2F;
        
        public const ushort SubCode_Reset = 0x01;
        public const ushort SubCode_SetAddress = 0x02;
        public const ushort SubCode_SetMUID = 0x03;
        public const ushort SubCode_SetCFG = 0x04;
        public const ushort SubCode_GetCFG = 0x05;

        #region 外部功能应用 

        public bool CFG_I2CCover
        {
            get
            {
                return PLCActive() && ((0 & 1) != 0);
            }
            set
            {
                if (PLCActive())
                {
                    if (value)
                    {
                        WriteSetReg(0, (ushort)(1 | 2));
                    }
                    else
                    {
                        WriteSetReg(0, (ushort)(1 & (~2)));
                    }
                }
            }
        }

        public int GetResultCount
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[0] : 0;
            }
        }

        public int ADICAResultCount
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICAResultCount] : 0;
            }
        }

        public int ADICAVRef
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICAVRef] : 0;
            }
        }

        public int ADICBResultCount
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICBResultCount] : 0;
            }
        }

        public int ADICBVRef
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICBVRef] : 0;
            }
        }

        public double A11
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA11] : 0;
                return fResult / 10;
            }
        }
        public double A12
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA12] : 0;
                return fResult / 10;
            }
        }
        public double A13
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA13] : 0;
                return fResult / 10;
            }
        }
        public double A14
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA14] : 0;
                return fResult / 10;
            }
        }
        public double A15
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA15] : 0;
                return fResult / 10;
            }
        }
        public double A16
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA16] : 0;
                return fResult / 10;
            }
        }
        public double A17
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA17] : 0;
                return fResult / 10;
            }
        }
        public double A21
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA21] : 0;
                return fResult / 10;
            }
        }
        public double A22
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA22] : 0;
                return fResult / 10;
            }
        }
        public double A23
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA23] : 0;
                return fResult / 10;
            }
        }
        public double A24
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA24] : 0;
                return fResult / 10;
            }
        }
        public double A25
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA25] : 0;
                return fResult / 10;
            }
        }
        public double A26
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA26] : 0;
                return fResult / 10;
            }
        }
        public double A27
        {
            get
            {
                double fResult = PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ADICA27] : 0;
                return fResult / 10;
            }
        }        
        
        public override bool PLCActive()
        {
            return (base.PLCActive()
                  && (fPLCModbusNode.RegCount == PLCRegCount));
        }
        #endregion

        #region 构建函数

        public ADP1701VX(ZLPLCModbusNode fPLCModbusNodeX, ZLPLCBusOnSerialPort fSerialPortBusX)
            : base(fPLCModbusNodeX, fSerialPortBusX)
        {
        }
        #endregion

        /// <summary>
        /// 设置PLC运行模式
        /// </summary>
        /// <param name="fPLCRunType"></param>
        public void SetPLCRunPlan(int fPLCRunType)
        {
            int fSleep = 350;
            // 4-20mA测量
            if (fPLCRunType == 1)
            {
               
                System.Threading.Thread.Sleep(fSleep);
            }
            // 结果应力测量
            if (fPLCRunType == 2)
            {
                
                System.Threading.Thread.Sleep(fSleep);
            }
        }

        public int GetPLCRunTimeCFG(out byte[] RTCFGDatas)
        {
            RTCFGDatas = new byte[0];

            TModbusRTUCommandV2 fCommand = new TModbusRTUCommandV2(ModbusCommand.HBHCCommand_0x42);
            fCommand.PLCAddress = (byte)this.PLCAddress;
            fCommand.MainCode = 0x03;
            fCommand.SubCode = SubCode_GetCFG;
            fCommand.CryptKey = 0;
            int fTimeOut = 100;
            int fResult =base.fSerialPortBus.SendModbusCommand(fCommand, ref fTimeOut);
            if ((fResult > 0) && fCommand.HasReply)
            {
                RTCFGDatas = new byte[fCommand.ReplyValues.Length*2];
                for(int i=0;i< fCommand.ReplyValues.Length;i++)
                {
                    RTCFGDatas[2 * i + 0] = (byte)((fCommand.ReplyValues[i] >> 8) & 0xFF);
                    RTCFGDatas[2 * i + 1] = (byte)(fCommand.ReplyValues[i] & 0xFF);
                }
            }
            return fResult;
        }

        public int SetPLCRunTimeCFG(ushort[] RTCFGDatas)
        {
            int fResult = 0;
               TModbusRTUCommandV2 fCommand = new TModbusRTUCommandV2(ModbusCommand.HBHCCommand_0x42);
            fCommand.PLCAddress = (byte)PLCAddress;
            fCommand.MainCode = 0x0A;
            fCommand.SubCode = ADP1701VX.SubCode_SetCFG;
            fCommand.CryptKey = (ushort)CRC16_GB19582.CRC16GB(PLCSNByteLF, TCRC16Endian.Big);
            fCommand.RegWriteCount = (ushort)RTCFGDatas.Length;
            for (int i = 0; i < fCommand.RegWriteCount; i++)
                fCommand.RegValue[i] = (ushort)RTCFGDatas[i];
            int fTimeOut = 100;
            fResult = base.fSerialPortBus.SendModbusCommand(fCommand, ref fTimeOut);           
            return fResult;
        }
    }
}
