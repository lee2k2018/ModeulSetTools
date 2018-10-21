using MSetTLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZLFMSTInputDialog;
using ZLSerialPortBusLib.PLCManager;

namespace C8051F350_YBExt_Manager
{
    public partial class FF350_YBExt : Form, LModuleSetTool
    {
        private F350YBExtPLC fF350YBExtPLC { get; set; }
        public FF350_YBExt(ZLPLCModbusNode fPLCModbusNodeX, ZLPLCBusOnSerialPort fSerialPortBusX)
        {
            InitializeComponent();
            Text += string.Format("[{0}]", "V1.180510");
            fF350YBExtPLC = new F350YBExtPLC(fPLCModbusNodeX, fSerialPortBusX);
            ClearAll();
        }

        #region 接口 ZLFMSetToolModel

        public void SetParent(Control fParent)
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
            this.TopLevel = false;
            this.Parent = fParent;
            this.Show();
        }

        public void CloseAll()
        {
            if (fF350YBExtPLC != null)
                fF350YBExtPLC.Close();
            fF350YBExtPLC = null;
            Close();
        }

        public void ClearAll()
        {
            labelVRef.Text = "0mV";
            labelT2Value.Text = "0";
            labelT3Value.Text = "0";
            labelT4Value.Text = "0";
            labelT5Value.Text = "0";
            labelT6Value.Text = "0";
            labelT7Value.Text = "0";
            labelT8Value.Text = "0";
            labelErrorCode.Text = "0x0000";
            linkLabelT3Set.Text = "0x0000";
            linkLabelT4Set.Text = "0x0000";
            linkLabelT5Set.Text = "0x0000";
            linkLabelT6Set.Text = "0x0000";
            linkLabelT7Set.Text = "0x0000";
            linkLabelT8Set.Text = "0x0000";
            linkLabelPLCAddress.Text = "0";
            textBoxPLCSN.Text = "";
            checkBoxSetI2CPort.Checked = false;
            checkBoxSetADCSpeed.Checked = false;
            checkBoxSetT2Value.Checked = false;
            listViewRegValue.Items.Clear();
        }

        #endregion

        private void fDeamon_Tick(object sender, EventArgs e)
        {
            if (fF350YBExtPLC.PLCConnected)
            {
                labelModbusAddress.Text = string.Format("Address: {0}(0x{1})",
                        fF350YBExtPLC.PLCAddress.ToString(),
                        fF350YBExtPLC.PLCAddress.ToString("X2"));
                if (fF350YBExtPLC.HasNewData)
                {
                    linkLabelPLCAddress.Text = string.Format("{0}(0x{1})", 
                        fF350YBExtPLC.PLCAddress.ToString(), 
                        fF350YBExtPLC.PLCAddress.ToString("X2"));
                    labelVRef.Text = string.Format("{0}mV", fF350YBExtPLC.VRef.ToString());
                    labelErrorCode.Text = string.Format("0x{0:X4}", fF350YBExtPLC.PLCErrorCode);
                    labelT2Value.Text = string.Format("{0}", fF350YBExtPLC.T2Value.ToString());
                    linkLabelT3Set.Text = string.Format("0x{0:X4}", fF350YBExtPLC.T3Set);
                    linkLabelT4Set.Text = string.Format("0x{0:X4}", fF350YBExtPLC.T4Set);
                    linkLabelT5Set.Text = string.Format("0x{0:X4}", fF350YBExtPLC.T5Set);
                    linkLabelT6Set.Text = string.Format("0x{0:X4}", fF350YBExtPLC.T6Set);
                    linkLabelT7Set.Text = string.Format("0x{0:X4}", fF350YBExtPLC.T7Set);
                    linkLabelT8Set.Text = string.Format("0x{0:X4}", fF350YBExtPLC.T8Set);

                    if (((fF350YBExtPLC.T3Set >> 8) & 0xFF) == 0)
                        labelT3Value.Text = string.Format("{0}", fF350YBExtPLC.T3Value.ToString());
                    else
                        labelT3Value.Text = string.Format("0x{0:X6}", fF350YBExtPLC.T3Value);

                    if (((fF350YBExtPLC.T4Set >> 8) & 0xFF) == 0)
                        labelT4Value.Text = string.Format("{0}", fF350YBExtPLC.T4Value.ToString());
                    else
                        labelT4Value.Text = string.Format("0x{0:X6}", fF350YBExtPLC.T4Value);

                    if (((fF350YBExtPLC.T5Set >> 8) & 0xFF) == 0)
                        labelT5Value.Text = string.Format("{0}", fF350YBExtPLC.T5Value.ToString());
                    else
                        labelT5Value.Text = string.Format("0x{0:X6}", fF350YBExtPLC.T5Value);

                    if (((fF350YBExtPLC.T6Set >> 8) & 0xFF) == 0)
                        labelT6Value.Text = string.Format("{0}", fF350YBExtPLC.T6Value.ToString());
                    else
                        labelT6Value.Text = string.Format("0x{0:X6}", fF350YBExtPLC.T6Value);

                    if (((fF350YBExtPLC.T7Set >> 8) & 0xFF) == 0)
                        labelT7Value.Text = string.Format("{0}", fF350YBExtPLC.T7Value.ToString());
                    else
                        labelT7Value.Text = string.Format("0x{0:X6}", fF350YBExtPLC.T7Value);

                    if (((fF350YBExtPLC.T8Set >> 8) & 0xFF) == 0)
                        labelT8Value.Text = string.Format("{0}", fF350YBExtPLC.T8Value.ToString());
                    else
                        labelT8Value.Text = string.Format("0x{0:X6}", fF350YBExtPLC.T8Value);

                    textBoxPLCSN.Text = fF350YBExtPLC.PLCSNStr;
                    checkBoxSetI2CPort.Checked = fF350YBExtPLC.CFG_I2CCover;
                    checkBoxSetADCSpeed.Checked = fF350YBExtPLC.CFG_ADCFastMode;
                    checkBoxSetT2Value.Checked = fF350YBExtPLC.CFG_T2Balance;

                    label20ADCResultCount.Text = fF350YBExtPLC.GetResultCount.ToString();

                    while (listViewRegValue.Items.Count < fF350YBExtPLC.RegistersCount)
                    {
                        ListViewItem fItem = new ListViewItem();
                        listViewRegValue.Items.Add(fItem);
                    }
                    for (int i = 0; i < fF350YBExtPLC.RegistersCount; i++)
                    {
                        int fValue = 0;
                        listViewRegValue.Items[i].SubItems.Clear();
                        listViewRegValue.Items[i].Text = string.Format("0x{0:X4}", i);
                        if (fF350YBExtPLC.GetRegValue(i, out fValue))
                        {
                            listViewRegValue.Items[i].SubItems.Add(fValue.ToString());
                            listViewRegValue.Items[i].SubItems.Add(string.Format("0x{0:X4}", fValue));
                            listViewRegValue.Items[i].SubItems.Add(string.Format("0x{0:X2}", (fValue >> 8) & 0xFF));
                            listViewRegValue.Items[i].SubItems.Add(string.Format("0x{0:X2}", fValue & 0xFF));
                        }
                    }
                }
            }
            else
                ClearAll();
        }
        /// <summary>
        /// 修改PLC地址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelPLCAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fF350YBExtPLC != null)
            {
                int fAddress = fF350YBExtPLC.PLCAddress;
                if (fF350YBExtPLC.PLCActive() && (InputBox_Int.InputIntBoxByte(ref fAddress, "PLC地址:")))
                {
                    fF350YBExtPLC.PLCAddress = fAddress;
                    Close();
                }
            }
        }
        /// <summary>
        /// 修改PLC序列号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPLCSN_DoubleClick(object sender, EventArgs e)
        {
            if (fF350YBExtPLC != null)
            {
                string fSN = textBoxPLCSN.Text;
                byte[] fPLCSNBytes = null;

                if (fF350YBExtPLC.PLCActive() && InputBox_PLCSN.InputPLCSN(ref fSN, out fPLCSNBytes))
                {
                    fF350YBExtPLC.PLCSNByte = fPLCSNBytes;
                }
            }
        }
        /// <summary>
        /// 修改通道配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelTXSet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if ((fF350YBExtPLC != null)&& fF350YBExtPLC.PLCActive())
            {
                LinkLabel fLinkLabel = (LinkLabel)sender;
                int fADCSet = 0;
                if (fLinkLabel.Name.Equals("linkLabelT3Set"))
                {
                    fADCSet = fF350YBExtPLC.T3Set;
                    if (Input_F350_ADCSet.InputADCSetBox(ref fADCSet))
                        fF350YBExtPLC.T3Set = fADCSet;
                }
                if (fLinkLabel.Name.Equals("linkLabelT4Set"))
                {
                    fADCSet = fF350YBExtPLC.T4Set;
                    if (Input_F350_ADCSet.InputADCSetBox(ref fADCSet))
                        fF350YBExtPLC.T4Set = fADCSet;
                }
                if (fLinkLabel.Name.Equals("linkLabelT5Set"))
                {
                    fADCSet = fF350YBExtPLC.T5Set;
                    if (Input_F350_ADCSet.InputADCSetBox(ref fADCSet))
                        fF350YBExtPLC.T5Set = fADCSet;
                }
                if (fLinkLabel.Name.Equals("linkLabelT6Set"))
                {
                    fADCSet = fF350YBExtPLC.T6Set;
                    if (Input_F350_ADCSet.InputADCSetBox(ref fADCSet))
                        fF350YBExtPLC.T6Set = fADCSet;
                }
                if (fLinkLabel.Name.Equals("linkLabelT7Set"))
                {
                    fADCSet = fF350YBExtPLC.T7Set;
                    if (Input_F350_ADCSet.InputADCSetBox(ref fADCSet))
                        fF350YBExtPLC.T7Set = fADCSet;
                }
                if (fLinkLabel.Name.Equals("linkLabelT8Set"))
                {
                    fADCSet = fF350YBExtPLC.T8Set;
                    if (Input_F350_ADCSet.InputADCSetBox(ref fADCSet))
                        fF350YBExtPLC.T8Set = fADCSet;
                }
            }
        }        
        /// <summary>
        /// 修改基础配置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSet_MouseClick(object sender, MouseEventArgs e)
        {
            if ((fF350YBExtPLC != null) && fF350YBExtPLC.PLCActive()
                && (e.Clicks == 1) && (e.Button == MouseButtons.Left))
            {
                CheckBox fCheckBox = (CheckBox)sender;
                if (fCheckBox.Name.Equals("checkBoxSetI2CPort"))
                    fF350YBExtPLC.CFG_I2CCover = !fF350YBExtPLC.CFG_I2CCover;
                if (fCheckBox.Name.Equals("checkBoxSetADCSpeed"))
                    fF350YBExtPLC.CFG_ADCFastMode = !fF350YBExtPLC.CFG_ADCFastMode;
                if (fCheckBox.Name.Equals("checkBoxSetT2Value"))
                    fF350YBExtPLC.CFG_T2Balance = !fF350YBExtPLC.CFG_T2Balance;
            }
        }
        /// <summary>
        /// 整体配置PLC运行模式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlanSet_Click(object sender, EventArgs e)
        {
            Input_F350_PlanSet.InputF350SetPlan(fF350YBExtPLC);
        }
    }
}
