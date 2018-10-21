using LModBusRTU;
using MSetTLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZLSerialPortBusLib.PLCManager;

namespace C8051F350_YBExt_Manager
{

    public class F350YBExtPLC: ModulePLCBase
    {
        public const int PLCRegCount = 0x20;       // 寄存器数量

        protected const int fCFGBitIdx_I2CCover = 1;
        protected const int fCFGBitIdx_ADCFastMode = 2;
        protected const int fCFGBitIdx_T2Balance = 4;
        
        protected const int fRegIdx_T3Set = 0x08;
        protected const int fRegIdx_T4Set = 0x09;
        protected const int fRegIdx_T5Set = 0x0A;
        protected const int fRegIdx_T6Set = 0x0B;
        protected const int fRegIdx_T7Set = 0x0C;
        protected const int fRegIdx_T8Set = 0x0D;
        protected const int fRegIdx_CFG = 0x0E;
        protected const int fRegIdx_ResultCount = 0x10;
        protected const int fRegIdx_VRef = 0x11;
        protected const int fRegIdx_T2ValueH = 0x12;
        protected const int fRegIdx_T2ValueL = 0x13;
        protected const int fRegIdx_T3ValueH = 0x14;
        protected const int fRegIdx_T4ValueH = 0x16;
        protected const int fRegIdx_T5ValueH = 0x18;
        protected const int fRegIdx_T6ValueH = 0x1A;
        protected const int fRegIdx_T7ValueH = 0x1C;
        protected const int fRegIdx_T8ValueH = 0x1E;
        protected const int fRegIdx_T3ValueL = 0x15;
        protected const int fRegIdx_T4ValueL = 0x17;
        protected const int fRegIdx_T5ValueL = 0x19;
        protected const int fRegIdx_T6ValueL = 0x1B;
        protected const int fRegIdx_T7ValueL = 0x1D;
        protected const int fRegIdx_T8ValueL = 0x1F;


        #region 外部功能应用 

        public int Reg_CFG
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_CFG] : 0;
            }
        }
        public bool CFG_I2CCover
        {
            get
            {
                return PLCActive() && ((Reg_CFG & fCFGBitIdx_I2CCover) != 0);
            }
            set
            {
                if (PLCActive())
                {
                    if (value)
                    {
                        WriteSetReg(fRegIdx_CFG, (ushort)(Reg_CFG | fCFGBitIdx_I2CCover));
                    }
                    else
                    {
                        WriteSetReg(fRegIdx_CFG, (ushort)(Reg_CFG & (~fCFGBitIdx_I2CCover)));
                    }
                }
            }
        }
        public bool CFG_ADCFastMode
        {
            get
            {
                return PLCActive() && ((Reg_CFG & fCFGBitIdx_ADCFastMode) != 0);
            }
            set
            {
                if (value)
                {
                    WriteSetReg(fRegIdx_CFG, (ushort)(Reg_CFG | fCFGBitIdx_ADCFastMode));
                }
                else
                {
                    WriteSetReg(fRegIdx_CFG, (ushort)(Reg_CFG & (~fCFGBitIdx_ADCFastMode)));
                }
            }
        }
        public bool CFG_T2Balance
        {
            get
            {
                return PLCActive() && ((Reg_CFG & fCFGBitIdx_T2Balance) != 0);
            }
            set
            {
                if (value)
                {
                    WriteSetReg(fRegIdx_CFG, (ushort)(Reg_CFG | fCFGBitIdx_T2Balance));
                }
                else
                {
                    WriteSetReg(fRegIdx_CFG, (ushort)(Reg_CFG & (~fCFGBitIdx_T2Balance)));
                }
            }
        }
      
        public int GetResultCount
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_ResultCount] : 0;
            }
        }
        public int VRef
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_VRef] : 0;
            }
        }

        public int T2Value
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_T2ValueL] : 0;
            }
        }
        public int T3Value
        {
            get
            {
                if (PLCActive())
                {
                    int fValue = fPLCModbusNode.RegValues[fRegIdx_T3ValueH];
                    return (fValue << 16) | fPLCModbusNode.RegValues[fRegIdx_T3ValueL];
                }
                return 0;
            }
        }
        public int T4Value
        {
            get
            {
                if (PLCActive())
                {
                    int fValue = fPLCModbusNode.RegValues[fRegIdx_T4ValueH];
                    return (fValue << 16) | fPLCModbusNode.RegValues[fRegIdx_T4ValueL];
                }
                return 0;
            }
        }
        public int T5Value
        {
            get
            {
                if (PLCActive())
                {
                    int fValue = fPLCModbusNode.RegValues[fRegIdx_T5ValueH];
                    return (fValue << 16) | fPLCModbusNode.RegValues[fRegIdx_T5ValueL];
                }
                return 0;
            }
        }
        public int T6Value
        {
            get
            {
                if (PLCActive())
                {
                    int fValue = fPLCModbusNode.RegValues[fRegIdx_T6ValueH];
                    return (fValue << 16) | fPLCModbusNode.RegValues[fRegIdx_T6ValueL];
                }
                return 0;
            }
        }
        public int T7Value
        {
            get
            {
                if (PLCActive())
                {
                    int fValue = fPLCModbusNode.RegValues[fRegIdx_T7ValueH];
                    return (fValue << 16) | fPLCModbusNode.RegValues[fRegIdx_T7ValueL];
                }
                return 0;
            }
        }
        public int T8Value
        {
            get
            {
                if (PLCActive())
                {
                    int fValue = fPLCModbusNode.RegValues[fRegIdx_T8ValueH];
                    return (fValue << 16) | fPLCModbusNode.RegValues[fRegIdx_T8ValueL];
                }
                return 0;
            }
        }
        public int T3Set
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_T3Set] : 0;
            }
            set
            {
                WriteSetReg(fRegIdx_T3Set, (ushort)value);
            }
        }
        public int T4Set
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_T4Set] : 0;
            }
            set
            {
                WriteSetReg(fRegIdx_T4Set, (ushort)value);
            }
        }
        public int T5Set
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_T5Set] : 0;
            }
            set
            {
                WriteSetReg(fRegIdx_T5Set, (ushort)value);
            }
        }
        public int T6Set
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_T6Set] : 0;
            }
            set
            {
                WriteSetReg(fRegIdx_T6Set, (ushort)value);
            }
        }
        public int T7Set
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_T7Set] : 0;
            }
            set
            {
                WriteSetReg(fRegIdx_T7Set, (ushort)value);
            }
        }
        public int T8Set
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[fRegIdx_T8Set] : 0;
            }
            set
            {
                WriteSetReg(fRegIdx_T8Set, (ushort)value);
            }
        }
       

        public override bool PLCActive()
        {
            return (base.PLCActive()
                  && (fPLCModbusNode.RegCount == PLCRegCount));           
        }
        #endregion
        
        #region 构建函数

        public F350YBExtPLC(ZLPLCModbusNode fPLCModbusNodeX, ZLPLCBusOnSerialPort fSerialPortBusX)
            :base(fPLCModbusNodeX, fSerialPortBusX)
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
                // 单极性测量；PGA增益=1；输入负为AGND
                T3Set = 0x0019;
                System.Threading.Thread.Sleep(fSleep);
                T4Set = 0x0029;
                System.Threading.Thread.Sleep(fSleep);
                T5Set = 0x0039;
                System.Threading.Thread.Sleep(fSleep);
                T6Set = 0x0049;
                System.Threading.Thread.Sleep(fSleep);
                T7Set = 0x0059;
                System.Threading.Thread.Sleep(fSleep);
                T8Set = 0x0069;
                System.Threading.Thread.Sleep(fSleep);
                // 快速测量模式
                CFG_ADCFastMode = true;
                System.Threading.Thread.Sleep(fSleep);
                // 通道2为差分方式测量片上温度温度，PGA增益=32
                CFG_T2Balance = false;
                System.Threading.Thread.Sleep(fSleep);
            }
            // 结果应力测量
            if (fPLCRunType == 2)
            {
                // 双极性测量；PGA增益=32；输入负为AIN0.7
                T3Set = 0x1517;
                System.Threading.Thread.Sleep(fSleep);
                T4Set = 0x1527;
                System.Threading.Thread.Sleep(fSleep);
                T5Set = 0x1537;
                System.Threading.Thread.Sleep(fSleep);
                T6Set = 0x1547;
                System.Threading.Thread.Sleep(fSleep);
                T7Set = 0x1557;
                System.Threading.Thread.Sleep(fSleep);
                T8Set = 0x1567;
                System.Threading.Thread.Sleep(fSleep);

                // 慢速测量模式
                CFG_ADCFastMode = false;
                System.Threading.Thread.Sleep(fSleep);
                // 通道2为测量AIN0.7专用平衡片上的绝对电压，PGA增益=1
                CFG_T2Balance = true;
                System.Threading.Thread.Sleep(fSleep);
            }
        }
    }
}
