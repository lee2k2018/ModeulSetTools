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

namespace MSetTLib
{
    public partial class FModuleSetBase : Form, LModuleSetTool
    {
        private ModulePLCBase fModulePLCBase { get; set; }

        public FModuleSetBase(ZLPLCModbusNode fPLCModbusNodeX, ZLPLCBusOnSerialPort fSerialPortBusX)
        {
            InitializeComponent();
            Text += string.Format("[{0}]", "V1.180510");
            fModulePLCBase = new ModulePLCBase(fPLCModbusNodeX, fSerialPortBusX);
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
            if (fModulePLCBase != null)
                fModulePLCBase.Close();
            fModulePLCBase = null;
            Close();
        }

        public void ClearAll()
        {
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
            if (fModulePLCBase.PLCConnected)
            {
                labelModbusAddress.Text = string.Format("Address: {0}(0x{1})",
                        fModulePLCBase.PLCAddress.ToString(),
                        fModulePLCBase.PLCAddress.ToString("X2"));
                if (fModulePLCBase.HasNewData)
                {
                    linkLabelPLCAddress.Text = string.Format("{0}(0x{1})",
                        fModulePLCBase.PLCAddress.ToString(),
                        fModulePLCBase.PLCAddress.ToString("X2"));
                   
                    labelErrorCode.Text = string.Format("0x{0:X4}", fModulePLCBase.PLCErrorCode);
                   
                    textBoxPLCSN.Text = fModulePLCBase.PLCSNStr;

                    while (listViewRegValue.Items.Count < fModulePLCBase.RegistersCount)
                    {
                        ListViewItem fItem = new ListViewItem();
                        listViewRegValue.Items.Add(fItem);
                    }
                    for (int i = 0; i < fModulePLCBase.RegistersCount; i++)
                    {
                        int fValue = 0;
                        listViewRegValue.Items[i].SubItems.Clear();
                        listViewRegValue.Items[i].Text = string.Format("0x{0:X4}", i);
                        listViewRegValue.Items[i].Tag = i;
                        if (fModulePLCBase.GetRegValue(i, out fValue))
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
            if (fModulePLCBase != null)
            {
                int fAddress = fModulePLCBase.PLCAddress;
                if (fModulePLCBase.PLCActive() && (InputBox_Int.InputIntBoxByte(ref fAddress, "PLC地址:")))
                {
                    fModulePLCBase.PLCAddress = fAddress;
                    Close();
                }
            }
        }

        private void textBoxPLCSN_DoubleClick(object sender, EventArgs e)
        {
            if (fModulePLCBase != null)
            {
                string fSN = textBoxPLCSN.Text;
                byte[] fPLCSNBytes = null;

                if (fModulePLCBase.PLCActive() && InputBox_PLCSN.InputPLCSN(ref fSN, out fPLCSNBytes))
                {
                    fModulePLCBase.PLCSNByte = fPLCSNBytes;
                }
            }
        }

        private void listViewRegValue_SelectedIndexChanged(object sender, EventArgs e)
        {            
            if ((listViewRegValue.SelectedItems.Count > 0)&&
                    (listViewRegValue.SelectedItems.Count == 1))
            {
                int fPLCRegAddr = -1;// Convert.ToInt32(listViewPLC.SelectedItems[0].Text.Substring(2), 16);
                int fRegValue = 0;

                if ((listViewRegValue.SelectedItems[0].Tag!=null)&&
                    int.TryParse(listViewRegValue.SelectedItems[0].Tag.ToString(), out fPLCRegAddr)
                    && (fPLCRegAddr>=0) && (listViewRegValue.SelectedItems[0].SubItems.Count>0)
                    &&int.TryParse(listViewRegValue.SelectedItems[0].SubItems[1].Text, out fRegValue)
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
                && fModulePLCBase.PLCActive()
                && InputBox_Int.InputIntBoxWord(ref fRegValue, "RegValue"))
            {
                fModulePLCBase.WriteReg((ushort)fPLCRegAddr, new ushort[] { (ushort)fRegValue });
            }            
        }
    }
}
