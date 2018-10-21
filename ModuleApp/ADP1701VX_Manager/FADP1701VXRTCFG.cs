using LModBusRTU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADP1701VX_Manager
{

    public partial class FADP1701VXRTCFG : Form
    {
        protected TADP1701VXRTCFG fADPCFG { get; set; }
        protected ADP1701VX fADP1701VX { get; set; }

        public FADP1701VXRTCFG(ADP1701VX DestADP1701VX)
        {
            fADP1701VX = DestADP1701VX;
            InitializeComponent();

            byte[] fTempData = null;
            int fResult = 0;
            if (fADP1701VX != null)
                fResult = fADP1701VX.GetPLCRunTimeCFG(out fTempData);
            if ((fResult > 0) && (fTempData != null))
                fADPCFG = new TADP1701VXRTCFG(fTempData);
            ShowCFG();
        }

        private void ShowCFG()
        {
            if (fADPCFG != null)
            {
                numericUpDownPLCAddress.Value = fADPCFG.PLCAddress;
                if (fADPCFG.ADICList[0].ICAddress != 0)
                {
                    checkBoxADICA.Checked = true;
                    numericUpDownADICAAddress.Value = fADPCFG.ADICList[0].ICAddress;
                    for (int i = 0; i < fADPCFG.ADICList[0].ICDef.Length; i++)
                        listBoxADICADef.Items[i] = (fADPCFG.ADICList[0].ICDef[i]-100).ToString();
                }
                else
                    checkBoxADICA.Checked = false;
                if (fADPCFG.ADICList[1].ICAddress != 0)
                {
                    checkBoxADICB.Checked = true;
                    numericUpDownADICBAddress.Value = fADPCFG.ADICList[1].ICAddress;
                    for (int i = 0; i < fADPCFG.ADICList[1].ICDef.Length; i++)
                        listBoxADICBDef.Items[i] = (fADPCFG.ADICList[1].ICDef[i]-100).ToString();
                }
                else
                    checkBoxADICB.Checked = false;

                checkBoxRS485RunMode.Checked = !fADPCFG.GetRTCBoolSet(TADP1701VXRTCFG.BoolSetIdx_RS485RunMode_Client);
            }
        }

        #region ADIC
        private void listBoxADICADef_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxADICADef.SelectedItems.Count > 0)
            {
                numericUpDownADICADef.Enabled = true;

                numericUpDownADICADef.Value = int.Parse(listBoxADICADef.Items[listBoxADICADef.SelectedIndex].ToString());
            }
            else
                numericUpDownADICADef.Enabled = false;
        }
        private void listBoxADICBDef_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxADICBDef.SelectedItems.Count > 0)
            {
                numericUpDownADICBDef.Enabled = true;

                numericUpDownADICBDef.Value = int.Parse(listBoxADICBDef.Items[listBoxADICBDef.SelectedIndex].ToString());
            }
            else
                numericUpDownADICBDef.Enabled = false;
        }
        private void numericUpDownADICADef_ValueChanged(object sender, EventArgs e)
        {
            if (listBoxADICADef.SelectedItems.Count > 0)
            {
                listBoxADICADef.Items[listBoxADICADef.SelectedIndex] = (int)numericUpDownADICADef.Value;
            }
        }
        private void numericUpDownADICBDef_ValueChanged(object sender, EventArgs e)
        {
            if (listBoxADICBDef.SelectedItems.Count > 0)
            {
                listBoxADICBDef.Items[listBoxADICBDef.SelectedIndex] = (int)numericUpDownADICBDef.Value;
            }
        }
        private void checkBoxADICA_CheckedChanged(object sender, EventArgs e)
        {
            panelADICA.Enabled = checkBoxADICA.Checked;
            if (!panelADICA.Enabled)
            {
                numericUpDownADICAAddress.Value = 0;
                if (fADPCFG != null)
                    fADPCFG.ADICList[0].ICAddress = 0;
            }
        }

        private void checkBoxADICB_CheckedChanged(object sender, EventArgs e)
        {
            panelADICB.Enabled = checkBoxADICB.Checked;
            if (!panelADICB.Enabled)
            {
                numericUpDownADICBAddress.Value = 0;
                if (fADPCFG != null)
                    fADPCFG.ADICList[1].ICAddress = 0;
            }
        }

        private void buttonSaveADCA_Click(object sender, EventArgs e)
        {
            fADPCFG.ADICList[0].ICAddress = (byte)numericUpDownADICAAddress.Value;
            for (int i = 0; i < fADPCFG.ADICList[0].ICDef.Length; i++)
            {
                fADPCFG.ADICList[0].ICDef[i] = (byte)(int.Parse(listBoxADICADef.Items[i].ToString()) + 100);
            }
            ShowCFG();
        }

        private void buttonSaveADCB_Click(object sender, EventArgs e)
        {
            fADPCFG.ADICList[1].ICAddress = (byte)numericUpDownADICBAddress.Value;
            for (int i = 0; i < fADPCFG.ADICList[1].ICDef.Length; i++)
                fADPCFG.ADICList[1].ICDef[i] = (byte)(int.Parse(listBoxADICBDef.Items[i].ToString()) + 100);
            ShowCFG();
        }

        #endregion

        #region ClientPLC
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if ((fADPCFG != null) &&
                ((radioButtonPLC1.Checked || radioButtonPLC2.Checked || radioButtonPLC3.Checked || radioButtonPLC4.Checked)))
            {
                int fClientPLCIdx = -1;
                if (radioButtonPLC1.Checked)
                    fClientPLCIdx = 0;
                if (radioButtonPLC2.Checked)
                    fClientPLCIdx = 1;
                if (radioButtonPLC3.Checked)
                    fClientPLCIdx = 2;
                if (radioButtonPLC4.Checked)
                    fClientPLCIdx = 3;
                if (fClientPLCIdx >= 0)
                {
                    checkBoxClientPLCEnable.Checked = (fADPCFG.ClientPLCList[fClientPLCIdx].ClientPLCAddr != 0);
                    if (checkBoxClientPLCEnable.Checked)
                    {
                        numericUpDownClientAddress.Value = fADPCFG.ClientPLCList[fClientPLCIdx].ClientPLCAddr;
                        numericUpDownClientRegStar.Value = fADPCFG.ClientPLCList[fClientPLCIdx].ClientRegStar;
                        numericUpDownClientRegCount.Value = fADPCFG.ClientPLCList[fClientPLCIdx].ClientRegCount;
                        numericUpDownSelfRegStar.Value = fADPCFG.ClientPLCList[fClientPLCIdx].SelfRegStar;
                        numericUpDownWriteBack.Value = fADPCFG.ClientPLCList[fClientPLCIdx].WriteBackCount;
                        numericUpDownWriteBackValue.Value = 0;
                        for (int i = 0; i < listBoxWriteBackDef.Items.Count; i++)
                            listBoxWriteBackDef.Items[i] = fADPCFG.ClientPLCList[fClientPLCIdx].WriteBackDef[i].ToString();
                    }
                }
            }
            else
            {
                checkBoxClientPLCEnable.Checked = false;
            }
        }
        private void checkBoxClientPLCEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxClientPLCEnable.Checked)
            {
                numericUpDownClientAddress.Value = 0;
                numericUpDownClientRegStar.Value = 0;
                numericUpDownClientRegCount.Value = numericUpDownClientRegCount.Minimum;
                numericUpDownSelfRegStar.Value = numericUpDownSelfRegStar.Minimum;
                numericUpDownWriteBack.Value = 0;
                numericUpDownWriteBackValue.Value = 0;
                for (int i = 0; i < listBoxWriteBackDef.Items.Count; i++)
                    listBoxWriteBackDef.Items[i] = "0";
            }
        }
        private void buttonClientPLC_Click(object sender, EventArgs e)
        {
            if ((fADPCFG != null) &&
                ((radioButtonPLC1.Checked || radioButtonPLC2.Checked || radioButtonPLC3.Checked || radioButtonPLC4.Checked)))
            {
                int fClientPLCIdx = -1;
                if (radioButtonPLC1.Checked)
                    fClientPLCIdx = 0;
                if (radioButtonPLC2.Checked)
                    fClientPLCIdx = 1;
                if (radioButtonPLC3.Checked)
                    fClientPLCIdx = 2;
                if (radioButtonPLC4.Checked)
                    fClientPLCIdx = 3;
                if (fClientPLCIdx >= 0)
                {
                    fADPCFG.ClientPLCList[fClientPLCIdx].ClientPLCAddr =
                        (byte)numericUpDownClientAddress.Value;
                    if (numericUpDownClientAddress.Value > 0)
                    {
                        fADPCFG.ClientPLCList[fClientPLCIdx].ClientPLCAddr = (byte)numericUpDownClientAddress.Value;
                        fADPCFG.ClientPLCList[fClientPLCIdx].ClientRegStar = (byte)numericUpDownClientRegStar.Value;
                        fADPCFG.ClientPLCList[fClientPLCIdx].ClientRegCount = (byte)numericUpDownClientRegCount.Value;
                        fADPCFG.ClientPLCList[fClientPLCIdx].SelfRegStar = (byte)numericUpDownSelfRegStar.Value;
                        fADPCFG.ClientPLCList[fClientPLCIdx].WriteBackCount = (byte)numericUpDownWriteBack.Value;

                        for (int i = 0; i < listBoxWriteBackDef.Items.Count; i++)
                            fADPCFG.ClientPLCList[fClientPLCIdx].WriteBackDef[i] = byte.Parse(listBoxWriteBackDef.Items[i].ToString());
                    }
                }
            }
            radioButton1_CheckedChanged(this, new EventArgs());
        }

        private void listBoxWriteBackDef_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxWriteBackDef.SelectedItems.Count > 0)
            {
                numericUpDownWriteBackValue.Enabled = true;

                numericUpDownWriteBackValue.Value = int.Parse(listBoxWriteBackDef.Items[listBoxWriteBackDef.SelectedIndex].ToString());
            }
            else
                numericUpDownWriteBackValue.Enabled = false;
        }

        private void numericUpDownWriteBackValue_ValueChanged(object sender, EventArgs e)
        {
            if (listBoxWriteBackDef.SelectedItems.Count > 0)
            {
                listBoxWriteBackDef.Items[listBoxWriteBackDef.SelectedIndex] = (int)numericUpDownWriteBackValue.Value;
            }
        }
        #endregion

        private void numericUpDownPLCAddress_ValueChanged(object sender, EventArgs e)
        {
            labelPLCAddress.Text = string.Format("0x{0}", ((int)numericUpDownPLCAddress.Value).ToString("X2"));
            labelADICA.Text = string.Format("0x{0}", ((int)numericUpDownADICAAddress.Value).ToString("X2"));
            labelADICB.Text = string.Format("0x{0}", ((int)numericUpDownADICBAddress.Value).ToString("X2"));
            labelClientAddress.Text = string.Format("0x{0}", ((int)numericUpDownClientAddress.Value).ToString("X2"));
            labelClientRegStar.Text = string.Format("0x{0}", ((int)numericUpDownClientRegStar.Value).ToString("X2"));
            labelClientRegCount.Text = string.Format("0x{0}", ((int)numericUpDownClientRegCount.Value).ToString("X2"));
            labelSelfRegStar.Text = string.Format("0x{0}", ((int)numericUpDownSelfRegStar.Value).ToString("X2"));
        }

        private void buttonWriteBack_Click(object sender, EventArgs e)
        {
            if ((fADPCFG != null) && (fADP1701VX != null)
                && (MessageBox.Show("是否保存结果", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes))
            {
                fADPCFG.PLCAddress = (byte)numericUpDownPLCAddress.Value;
                fADPCFG.SetRTCBoolSet(TADP1701VXRTCFG.BoolSetIdx_RS485RunMode_Client,
                    !checkBoxRS485RunMode.Checked);
                fADP1701VX.SetPLCRunTimeCFG(fADPCFG.GetRTCFGWordData());
                Close();
            }
        }

        private void checkBoxRS485RunMode_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxClientPLC.Enabled = checkBoxRS485RunMode.Checked;
        }
    }


    public struct ClientPLCInfo
    {
        public byte ClientPLCAddr;
        public ushort ClientRegStar;
        public byte ClientRegCount;
        public ushort SelfRegStar;
        public byte WriteBackCount;
        public byte[] WriteBackDef;
    }
    public struct ADICInfo
    {
        public byte ICAddress;
        public byte[] ICDef;
    }

    public class TADP1701VXRTCFG
    {
        protected static int CFGDSize = 0x4A;
        protected static int CFGDIdx_Address = 0;
        protected static int CFGDIdx_BoolSet = 1;
        protected static int CFGDIdx_ADICA = 3;
        protected static int CFGDIdx_ADICADef0 = 2;
        protected static int CFGDIdx_ADICADef1 = 5;
        protected static int CFGDIdx_ADICADef2 = 4;
        protected static int CFGDIdx_ADICADef3 = 7;
        protected static int CFGDIdx_ADICADef4 = 6;
        protected static int CFGDIdx_ADICADef5 = 9;
        protected static int CFGDIdx_ADICADef6 = 8;

        protected static int CFGDIdx_ADICB = 11;
        protected static int CFGDIdx_ADICBDef0 = 10;
        protected static int CFGDIdx_ADICBDef1 = 13;
        protected static int CFGDIdx_ADICBDef2 = 12;
        protected static int CFGDIdx_ADICBDef3 = 15;
        protected static int CFGDIdx_ADICBDef4 = 14;
        protected static int CFGDIdx_ADICBDef5 = 17;
        protected static int CFGDIdx_ADICBDef6 = 16;

        protected static int CFGDIdx_Cli0 = 18;
        protected static int CFGDIdx_CliDef_RegStarH = 0;
        protected static int CFGDIdx_CliDef_RegStarL = 1;
        protected static int CFGDIdx_CliDef_SelfRegStarH = 2;
        protected static int CFGDIdx_CliDef_SelfRegStarL = 3;
        protected static int CFGDIdx_CliDef_PLCAddr = 5;
        protected static int CFGDIdx_CliDef_RegCount = 4;
        protected static int CFGDIdx_CliDef_WriteBackCount = 7;
        protected static int CFGDIdx_CliDef_WriteBackDef0 = 6;
        protected static int CFGDIdx_CliDef_WriteBackDef1 = 9;
        protected static int CFGDIdx_CliDef_WriteBackDef2 = 8;
        protected static int CFGDIdx_CliDef_WriteBackDef3 = 11;
        protected static int CFGDIdx_CliDef_WriteBackDef4 = 10;
        protected static int CFGDIdx_CliDef_WriteBackDef5 = 13;
        protected static int CFGDIdx_CliDef_WriteBackDef6 = 12;

        public static int BoolSetIdx_RS485RunMode_Client = 0;


        protected List<byte> fDatas = new List<byte>();
        public byte PLCAddress
        {
            get
            {
                if (RTCFGActive)
                    return fDatas[CFGDIdx_Address];
                else
                    return 0;
            }
            set { if ((value > 0) && RTCFGActive) fDatas[CFGDIdx_Address] = value; }
        }

        protected ADICInfo[] fADICList = new ADICInfo[2];
        public ADICInfo[] ADICList
        {
            get { return fADICList; }
            set
            {
                if (value.Length == 2)
                    fADICList = value;
            }
        }
        protected ClientPLCInfo[] fClientPLCList = new ClientPLCInfo[4];
        public ClientPLCInfo[] ClientPLCList
        {
            get { return fClientPLCList; }
            set
            {
                if (value.Length == 4)
                    fClientPLCList = value;
            }
        }

        public bool RTCFGActive
        {
            get { return fDatas.Count == CFGDSize; }
        }

        public TADP1701VXRTCFG(byte[] bRTCFGDatas)
        {
            if ((bRTCFGDatas != null)
                && (bRTCFGDatas.Length == CFGDSize))
            {
                fDatas = new List<byte>(bRTCFGDatas);
                ConvertDataToCFG();
            }
        }

        public TADP1701VXRTCFG(ushort[] bRTCFGDatas)
        {
            if ((bRTCFGDatas != null) && (bRTCFGDatas.Length == CFGDSize))
            {
                byte[] bBuf = new byte[bRTCFGDatas.Length * 2];
                for (int i = 0; i < bRTCFGDatas.Length; i++)
                {
                    bBuf[2 * i + 0] = (byte)(bRTCFGDatas[i] >> 8);
                    bBuf[2 * i + 1] = (byte)(bRTCFGDatas[i] & 0xFF);
                }
                fDatas = new List<byte>(bBuf);
                ConvertDataToCFG();
            }
        }

        protected void ConvertDataToCFG()
        {
            fADICList[0].ICAddress = fDatas[CFGDIdx_ADICA];
            fADICList[0].ICDef = new byte[7];
            fADICList[0].ICDef[0] = fDatas[CFGDIdx_ADICADef0];
            fADICList[0].ICDef[1] = fDatas[CFGDIdx_ADICADef1];
            fADICList[0].ICDef[2] = fDatas[CFGDIdx_ADICADef2];
            fADICList[0].ICDef[3] = fDatas[CFGDIdx_ADICADef3];
            fADICList[0].ICDef[4] = fDatas[CFGDIdx_ADICADef4];
            fADICList[0].ICDef[5] = fDatas[CFGDIdx_ADICADef5];
            fADICList[0].ICDef[6] = fDatas[CFGDIdx_ADICADef6];

            fADICList[1].ICAddress = fDatas[CFGDIdx_ADICB];
            fADICList[1].ICDef = new byte[7];
            fADICList[1].ICDef[0] = fDatas[CFGDIdx_ADICBDef0];
            fADICList[1].ICDef[1] = fDatas[CFGDIdx_ADICBDef1];
            fADICList[1].ICDef[2] = fDatas[CFGDIdx_ADICBDef2];
            fADICList[1].ICDef[3] = fDatas[CFGDIdx_ADICBDef3];
            fADICList[1].ICDef[4] = fDatas[CFGDIdx_ADICBDef4];
            fADICList[1].ICDef[5] = fDatas[CFGDIdx_ADICBDef5];
            fADICList[1].ICDef[6] = fDatas[CFGDIdx_ADICBDef6];

            for (int i = 0; i < fClientPLCList.Length; i++)
            {
                int fBaseDef = CFGDIdx_Cli0 + 14 * i;
                ClientPLCList[i].ClientPLCAddr =
                    fDatas[fBaseDef + CFGDIdx_CliDef_PLCAddr];
                ClientPLCList[i].ClientRegStar =
                    fDatas[fBaseDef + CFGDIdx_CliDef_RegStarH];
                ClientPLCList[i].ClientRegStar <<= 8;
                ClientPLCList[i].ClientRegStar |=
                    fDatas[fBaseDef + CFGDIdx_CliDef_RegStarL];
                ClientPLCList[i].ClientRegCount =
                    fDatas[fBaseDef + CFGDIdx_CliDef_RegCount];

                ClientPLCList[i].SelfRegStar =
                    fDatas[fBaseDef + CFGDIdx_CliDef_SelfRegStarH];
                ClientPLCList[i].SelfRegStar <<= 8;
                ClientPLCList[i].SelfRegStar |=
                    fDatas[fBaseDef + CFGDIdx_CliDef_SelfRegStarL];

                ClientPLCList[i].WriteBackCount =
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackCount];

                ClientPLCList[i].WriteBackDef = new byte[7];
                ClientPLCList[i].WriteBackDef[0] =
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef0];
                ClientPLCList[i].WriteBackDef[1] =
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef1];
                ClientPLCList[i].WriteBackDef[2] =
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef2];
                ClientPLCList[i].WriteBackDef[3] =
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef3];
                ClientPLCList[i].WriteBackDef[4] =
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef4];
                ClientPLCList[i].WriteBackDef[5] =
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef5];
                ClientPLCList[i].WriteBackDef[6] =
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef6];
            }
        }

        public bool GetRTCBoolSet(int iIdx)
        {
            if ((iIdx >= 0) & (iIdx < 8))
                return ((fDatas[CFGDIdx_BoolSet] >> iIdx) & 1) != 0;
            return false;
        }

        public void SetRTCBoolSet(int iIdx,bool value)
        {
            if ((iIdx >= 0) & (iIdx < 8))
            {
                int iTemp = 1 << iIdx;
                fDatas[CFGDIdx_BoolSet] = (byte)(fDatas[CFGDIdx_BoolSet] & (~iTemp));
                iTemp = value ? 1 : 0;
                iTemp <<= iIdx;
                fDatas[CFGDIdx_BoolSet] = (byte)(fDatas[CFGDIdx_BoolSet] | iTemp);
            }
        }

        public byte[] GetRTCFGByteData()
        {
            if (RTCFGActive)
            {
                fDatas[CFGDIdx_ADICA] = fADICList[0].ICAddress;
                fDatas[CFGDIdx_ADICADef0] = fADICList[0].ICDef[0];
                fDatas[CFGDIdx_ADICADef1] = fADICList[0].ICDef[1];
                fDatas[CFGDIdx_ADICADef2] = fADICList[0].ICDef[2];
                fDatas[CFGDIdx_ADICADef3] = fADICList[0].ICDef[3];
                fDatas[CFGDIdx_ADICADef4] = fADICList[0].ICDef[4];
                fDatas[CFGDIdx_ADICADef5] = fADICList[0].ICDef[5];
                fDatas[CFGDIdx_ADICADef6] = fADICList[0].ICDef[6];


                fDatas[CFGDIdx_ADICB] = fADICList[1].ICAddress;
                fDatas[CFGDIdx_ADICBDef0] = fADICList[1].ICDef[0];
                fDatas[CFGDIdx_ADICBDef1] = fADICList[1].ICDef[1];
                fDatas[CFGDIdx_ADICBDef2] = fADICList[1].ICDef[2];
                fDatas[CFGDIdx_ADICBDef3] = fADICList[1].ICDef[3];
                fDatas[CFGDIdx_ADICBDef4] = fADICList[1].ICDef[4];
                fDatas[CFGDIdx_ADICBDef5] = fADICList[1].ICDef[5];
                fDatas[CFGDIdx_ADICBDef6] = fADICList[1].ICDef[6];

                for (int i = 0; i < fClientPLCList.Length; i++)
                {
                    int fBaseDef = CFGDIdx_Cli0 + 14 * i;
                    fDatas[fBaseDef + CFGDIdx_CliDef_PLCAddr] =
                        ClientPLCList[i].ClientPLCAddr;
                    fDatas[fBaseDef + CFGDIdx_CliDef_RegStarH] = (byte)(ClientPLCList[i].ClientRegStar >> 8);
                    fDatas[fBaseDef + CFGDIdx_CliDef_RegStarL] = (byte)(ClientPLCList[i].ClientRegStar & 0xFF);
                    fDatas[fBaseDef + CFGDIdx_CliDef_RegCount] = ClientPLCList[i].ClientRegCount;

                    fDatas[fBaseDef + CFGDIdx_CliDef_SelfRegStarH] = (byte)(ClientPLCList[i].SelfRegStar >> 8);
                    fDatas[fBaseDef + CFGDIdx_CliDef_SelfRegStarL] = (byte)(ClientPLCList[i].SelfRegStar & 0xFF);

                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackCount] = ClientPLCList[i].WriteBackCount;

                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef0] =
                        ClientPLCList[i].WriteBackDef[0];
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef1] =
                        ClientPLCList[i].WriteBackDef[1];
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef2] =
                        ClientPLCList[i].WriteBackDef[2];
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef3] =
                        ClientPLCList[i].WriteBackDef[3];
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef4] =
                        ClientPLCList[i].WriteBackDef[4];
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef5] =
                        ClientPLCList[i].WriteBackDef[5];
                    fDatas[fBaseDef + CFGDIdx_CliDef_WriteBackDef6] =
                        ClientPLCList[i].WriteBackDef[6];
                }
                return fDatas.ToArray();
            }
            else
                return null;
        }

        public ushort[] GetRTCFGWordData()
        {
            byte[] fBuf = GetRTCFGByteData();
            List<ushort> fResult = new List<ushort>();
            for(int i=0;i<(fBuf.Length/2);i++)
            {
                ushort fTemp = fBuf[i * 2 + 0];
                fTemp <<= 8;
                fTemp|= fBuf[i * 2 + 1];
                fResult.Add(fTemp);
            }
            return fResult.ToArray();
        }
    }

}
