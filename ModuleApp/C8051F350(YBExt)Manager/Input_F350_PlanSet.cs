using LModBusRTU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZLFM_C8051F350_STV1
{
    public partial class Input_F350_PlanSet : Form
    {
        ZLFMF350PLC_STV1 fModelManager { get; set; }
        public Input_F350_PlanSet(ZLFMF350PLC_STV1 fModelManagerX)
        {
            InitializeComponent();
            fModelManager = fModelManagerX;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked || radioButton2.Checked)&&(fModelManager!=null)&& (fModelManager.PLCConnected))
            {
                int fCRCValue = CRC16_GB19582.CRC16CB(fModelManager.PLCSNByteLF);
                int[] fDataBuf;
                fModelManager.Active = false;
                System.Threading.Thread.Sleep(100);
                try
                {
                    // 4-20mA测量
                    if (radioButton1.Checked)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            // 单极性测量；PGA增益=1；输入负为AGND
                            fDataBuf = new int[] { fCRCValue, 0x0009 | ((i + 1) << 4) };
                            fModelManager.WriteRegValueNoFeamon(fModelManager.PLCAddress, 0x08 + i, fDataBuf);
                            System.Threading.Thread.Sleep(5);
                        }
                        // 快速测量模式
                        fModelManager.CFG_ADCFastMode = true;
                        // 通道2为差分方式测量片上温度温度，PGA增益=32
                        fModelManager.CFG_T2Balance = false;
                        // 写入系统配置
                        fDataBuf = new int[] { fCRCValue, fModelManager.Reg_CFG };
                        fModelManager.WriteRegValueNoFeamon(fModelManager.PLCAddress, 0x0E, fDataBuf);
                        System.Threading.Thread.Sleep(5);
                        // 重启PLC
                        fDataBuf = new int[] { fCRCValue, 1 };
                        fModelManager.WriteRegValueNoFeamon(fModelManager.PLCAddress, 1, fDataBuf);
                    }

                    if (radioButton2.Checked)
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            // 双极性测量；PGA增益=32；输入负为AIN0.7
                            fDataBuf = new int[] { fCRCValue, 0x1507 | ((i + 1) << 4) };
                            fModelManager.WriteRegValueNoFeamon(fModelManager.PLCAddress, 0x08 + i, fDataBuf);
                            System.Threading.Thread.Sleep(5);
                        }
                        // 慢速测量模式
                        fModelManager.CFG_ADCFastMode = false;
                        // 通道2为测量专用平衡片上的绝对电压，PGA增益=1
                        fModelManager.CFG_T2Balance = true;
                        // 写入系统配置
                        fDataBuf = new int[] { fCRCValue, fModelManager.Reg_CFG };
                        fModelManager.WriteRegValueNoFeamon(fModelManager.PLCAddress, 0x0E, fDataBuf);
                        System.Threading.Thread.Sleep(5);
                        // 重启PLC
                        fDataBuf = new int[] { fCRCValue, 1 };
                        fModelManager.WriteRegValueNoFeamon(fModelManager.PLCAddress, 1, fDataBuf);
                    }
                }
                finally
                {
                    fModelManager.Active = true;
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        public static bool InputF350SetPlan(ZLFMF350PLC_STV1 fModelManagerX)
        {
            Input_F350_PlanSet fInputPlanSet = new Input_F350_PlanSet(fModelManagerX);
            fInputPlanSet.ShowDialog();
            return fInputPlanSet.DialogResult == DialogResult.OK;
        }
    }
}
