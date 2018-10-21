using MSetTLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZLSerialPortBusLib.PLCManager;

namespace ADP1701VX_Manager
{
    public class ADP1701VX : ModulePLCBase
    {
        public const int PLCRegCount = 0x60;       // 寄存器数量
        
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
        public int VRef
        {
            get
            {
                return PLCActive() ? fPLCModbusNode.RegValues[0] : 0;
            }
        }
        
        public int T3Value
        {
            get
            {
                if (PLCActive())
                {
                    int fValue = fPLCModbusNode.RegValues[0];
                    return (fValue << 16) | fPLCModbusNode.RegValues[0];
                }
                return 0;
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
    }
}
