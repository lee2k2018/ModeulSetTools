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

namespace ADP1701VX_Manager
{
    /// <summary>
    /// 修改说明：
    /// 2018-10-17：
    ///   1、增加向PLC寄存器写回操作，该操作仅能向1个地址写回数据；
    /// </summary>
    public partial class FADP1701VX : Form ,LModuleSetTool
    {
        private ADP1701VX fADP1701VXPLC { get; set; }
        public FADP1701VX(ZLPLCModbusNode fPLCModbusNodeX, ZLPLCBusOnSerialPort fSerialPortBusX)
        {
            InitializeComponent();
            Text += string.Format("[{0}]", "V1.180510");
            fADP1701VXPLC = new ADP1701VX(fPLCModbusNodeX, fSerialPortBusX);
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
            if (fADP1701VXPLC != null)
                fADP1701VXPLC.Close();
            fADP1701VXPLC = null;
            Close();
        }

        public void ClearAll()
        {
            labelADCAResultCount.Text = "0";
            labelADCBResultCount.Text = "0";
            labelAVRef.Text = "0" + "mV";
            labelBVRef.Text = "0" + "mV";

            labelA11.Text = "0" + "mV";
            labelA12.Text = "0" + "mV";
            labelA13.Text = "0" + "mV";
            labelA14.Text = "0" + "mV";
            labelA15.Text = "0" + "mV";
            labelA16.Text = "0" + "mV";
            labelA17.Text = "0" + "mV";
            labelA21.Text = "0" + "mV";
            labelA22.Text = "0" + "mV";
            labelA23.Text = "0" + "mV";
            labelA24.Text = "0" + "mV";
            labelA25.Text = "0" + "mV";
            labelA26.Text = "0" + "mV";
            labelA27.Text = "0" + "mV";

            linkLabelPLCAddress.Text = "0";
            textBoxPLCSN.Text = "";
            listViewRegValue.Items.Clear();

            labelRegAddress.Text = "0";
            labelRegValue_10.Text = "0";
            labelRegValue_16.Text = "0x00";
            buttonSetRegValue.Visible = false;
        }

        #endregion

        private void fDeamon_Tick(object sender, EventArgs e)
        {
            if (fADP1701VXPLC.PLCConnected)
            {
                labelModbusAddress.Text = string.Format("Address: {0}(0x{1})",
                        fADP1701VXPLC.PLCAddress.ToString(),
                        fADP1701VXPLC.PLCAddress.ToString("X2"));
                if (fADP1701VXPLC.HasNewData)
                {
                    linkLabelPLCAddress.Text = string.Format("{0}(0x{1})",
                        fADP1701VXPLC.PLCAddress.ToString(),
                        fADP1701VXPLC.PLCAddress.ToString("X2"));

                    labelADCAResultCount.Text = fADP1701VXPLC.ADICAResultCount.ToString();
                    labelADCBResultCount.Text = fADP1701VXPLC.ADICBResultCount.ToString();
                    labelAVRef.Text = fADP1701VXPLC.ADICAVRef.ToString() + "mV";
                    labelBVRef.Text = fADP1701VXPLC.ADICBVRef.ToString() + "mV";

                    labelA11.Text = fADP1701VXPLC.A11.ToString("0.0") + "mV";
                    labelA12.Text = fADP1701VXPLC.A12.ToString("0.0") + "mV";
                    labelA13.Text = fADP1701VXPLC.A13.ToString("0.0") + "mV";
                    labelA14.Text = fADP1701VXPLC.A14.ToString("0.0") + "mV";
                    labelA15.Text = fADP1701VXPLC.A15.ToString("0.0") + "mV";
                    labelA16.Text = fADP1701VXPLC.A16.ToString("0.0") + "mV";
                    labelA17.Text = fADP1701VXPLC.A17.ToString("0.0") + "mV";
                    labelA21.Text = fADP1701VXPLC.A21.ToString("0.0") + "mV";
                    labelA22.Text = fADP1701VXPLC.A22.ToString("0.0") + "mV";
                    labelA23.Text = fADP1701VXPLC.A23.ToString("0.0") + "mV";
                    labelA24.Text = fADP1701VXPLC.A24.ToString("0.0") + "mV";
                    labelA25.Text = fADP1701VXPLC.A25.ToString("0.0") + "mV";
                    labelA26.Text = fADP1701VXPLC.A26.ToString("0.0") + "mV";
                    labelA27.Text = fADP1701VXPLC.A27.ToString("0.0") + "mV";

                    textBoxPLCSN.Text = fADP1701VXPLC.PLCSNStr;

                    while (listViewRegValue.Items.Count < fADP1701VXPLC.RegistersCount)
                    {
                        ListViewItem fItem = new ListViewItem();
                        listViewRegValue.Items.Add(fItem);
                    }
                    for (int i = 0; i < fADP1701VXPLC.RegistersCount; i++)
                    {
                        int fValue = 0;
                        listViewRegValue.Items[i].SubItems.Clear();
                        listViewRegValue.Items[i].Text = string.Format("0x{0:X4}", i);
                        listViewRegValue.Items[i].Tag = i;
                        if (fADP1701VXPLC.GetRegValue(i, out fValue))
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

        private void linkLabelPLCAddress_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (fADP1701VXPLC != null)
            {
                int fAddress = fADP1701VXPLC.PLCAddress;
                if (fADP1701VXPLC.PLCActive() && (InputBox_Int.InputIntBoxByte(ref fAddress, "PLC地址:")))
                {
                    fADP1701VXPLC.PLCAddress = fAddress;
                    Close();
                }
            }
        }

        private void buttonRTCFG_Click(object sender, EventArgs e)
        {
            if (fADP1701VXPLC != null)
            {
                FADP1701VXRTCFG fADP1701VXRTCFG = new FADP1701VXRTCFG(fADP1701VXPLC);
                fADP1701VXRTCFG.ShowDialog();
            }
        }

        private void listViewRegValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((listViewRegValue.SelectedItems.Count > 0) &&
                    (listViewRegValue.SelectedItems.Count == 1))
            {
                int fPLCRegAddr = -1;// Convert.ToInt32(listViewPLC.SelectedItems[0].Text.Substring(2), 16);
                int fRegValue = 0;

                if ((listViewRegValue.SelectedItems[0].Tag != null) &&
                    int.TryParse(listViewRegValue.SelectedItems[0].Tag.ToString(), out fPLCRegAddr)
                    && (fPLCRegAddr >= 0) && (listViewRegValue.SelectedItems[0].SubItems.Count > 0)
                    && int.TryParse(listViewRegValue.SelectedItems[0].SubItems[1].Text, out fRegValue)
                    )
                {
                    labelRegAddress.Tag = fPLCRegAddr;
                    labelRegAddress.Text = string.Format("0x{0:X4}", fPLCRegAddr);
                    labelRegValue_10.Text = fRegValue.ToString();
                    labelRegValue_10.Tag = fRegValue;
                    labelRegValue_16.Text = string.Format("0x{0:X4}", fRegValue);
                    buttonSetRegValue.Visible = true;
                }
            }
            else
            {
                labelRegAddress.Text = "0";
                labelRegValue_10.Text = "0";
                labelRegValue_16.Text = "0x00";
                buttonSetRegValue.Visible = false;
            }
        }

        private void buttonSetRegValue_Click(object sender, EventArgs e)
        {
            int fPLCRegAddr = -1;
            int fRegValue = 0;
            if ((labelRegAddress.Tag != null) &&
                int.TryParse(labelRegAddress.Tag.ToString(), out fPLCRegAddr)
                && (labelRegValue_10.Tag != null) &&
                int.TryParse(labelRegValue_10.Tag.ToString(), out fRegValue)
                && fADP1701VXPLC.PLCActive()
                && InputBox_Int.InputIntBoxWord(ref fRegValue, "RegValue"))
            {
                fADP1701VXPLC.WriteReg((ushort)fPLCRegAddr, new ushort[] { (ushort)fRegValue });
            }
        }
    }
}
