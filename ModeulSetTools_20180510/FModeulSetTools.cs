using ADP1701VX_Manager;
using C8051F350_YBExt_Manager;
using HCLSMod;
using LModBusRTU;
using MSetTLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZLSerialPortBusLib;
using ZLSerialPortBusLib.LogView;
using ZLSerialPortBusLib.PLCManager;

namespace ModeulSetTools
{
    public partial class FModeulSetTools : Form
    {        
        ZLPLCBusOnSerialPort fSerialPLC { get; set; }
        ISerialPortBusCFG fSerialPortBusConfig { get; set; }
        int fButtonTick { get; set; }
        Form ModulForm { get; set; }

        FLogView fLogView { get; set; }

        public FModeulSetTools()
        {
            InitializeComponent();
            fSerialPortBusConfig = new SerialPortBusConfig(IniFile.NewIniFileName(), 0);
            fSerialPLC = new ZLPLCBusOnSerialPort(fSerialPortBusConfig);
            fButtonTick = 0;
            fLogView = new FLogView(fSerialPLC);
            fLogView.SetParent(groupBoxRunLog);
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            FSerialPLCManager fSerialBusConfigForm = new FSerialPLCManager(fSerialPLC);
            fSerialBusConfigForm.ShowDialog();
        }

        private void FModeulSetTools_Demo_FormClosed(object sender, FormClosedEventArgs e)
        {
            fSerialPLC.CloseBus();
            fSerialPLC = null;
        }

        private void fDeamon_Tick(object sender, EventArgs e)
        {
            if (fSerialPLC != null)
            {
                textBoxBusInfo.Text = fSerialPLC.SerialPortInfo;                
            }
            else
            {
                textBoxBusInfo.Text = "";
                buttonStarStopBus.Text = "StarBus";
                panelBusManager.Visible = false;
                splitContainerPLCManager.Visible = false;
            }
            if (fSerialPLC != null)
            {
                if (fSerialPLC.Active)
                {
                    buttonStarStopBus.Text = "StopBus";
                    panelBusManager.Visible = true;
                    splitContainerPLCManager.Visible = true;

                    if (fSerialPLC.SerialPortModbus!=null)
                    {                       
                        if (ModulForm == null)
                            panelBusManager.Enabled = true;
                    }
                }
                else
                {
                    buttonStarStopBus.Text = "StarBus";
                    panelBusManager.Visible = false;
                    splitContainerPLCManager.Visible = false;
                }
            }
            toolStripStatusLabel2.Text = fButtonTick.ToString();
        }

        private void buttonStarStopBus_Click(object sender, EventArgs e)
        {
            if (fSerialPLC != null)
            {
                if (fSerialPLC.Active)
                {
                    fSerialPLC.StopBus();
                    if (ModulForm!=null)
                    {
                        ModulForm.Close();
                        ModulForm = null;
                    }
                    comboBoxPLCType.SelectedIndex = -1;
                }
                else
                {
                    fSerialPLC.StarBus();
                    if (fSerialPLC.Active)
                    {
                        fSerialPLC.ClearAllPLCNode();
                        fSerialPLC.ResponTimeOut = 150;
                        comboBoxPLCType.SelectedIndex = 0;
                        numericUpDownDestPLCAddress.Value = 0;
                    }
                }
            }
        }

        private void buttonOpenPLC_Click(object sender, EventArgs e)
        {
            fSerialPLC.ClearAllPLCNode();
            ModulForm = null;

            TModbusRTUCommandV2 fCommand = new TModbusRTUCommandV2(ModbusCommand.ReadMemoryReg_0x03);
            fCommand.PLCAddress = (byte)numericUpDownDestPLCAddress.Value;
            fCommand.RegReadAddress = 0;
            fCommand.RegReadCount = 1;
            fCommand.OnGetRTURespon += FCommand_OnGetRTURespon;
            int fTimeOut = 100;
            fSerialPLC.SendModbusCommand(fCommand, ref fTimeOut);
        }

        private void FCommand_OnGetRTURespon(object sender)
        {
            TModbusRTUCommandV2 fCommand = (TModbusRTUCommandV2)sender;
            panelBusManager.Enabled = false;
            ZLPLCModbusNode fPLCNode = null;
            switch (comboBoxPLCType.SelectedIndex)
            {
                case 0:
                    fPLCNode = new ZLPLCModbusNode(fCommand.PLCAddress, ModulePLCBase.RegStar, ModulePLCBase.SystemRegCount);
                    fSerialPLC.AddNewPLCNode(fPLCNode);
                    fPLCNode.IntervalOfFlash = 1000;
                    ModulForm = new FModuleSetBase(fPLCNode, fSerialPLC);
                    break;
                case 1:
                    fPLCNode= new ZLPLCModbusNode(fCommand.PLCAddress, F350YBExtPLC.RegStar, F350YBExtPLC.PLCRegCount);
                    fSerialPLC.AddNewPLCNode(fPLCNode);
                    fPLCNode.IntervalOfFlash = 1000;
                    ModulForm = new FF350_YBExt(fPLCNode, fSerialPLC);
                    break;
                case 2:
                    fPLCNode = new ZLPLCModbusNode(fCommand.PLCAddress, ADP1701VX.RegStar, ADP1701VX.PLCRegCount);
                    fSerialPLC.AddNewPLCNode(fPLCNode);
                    fPLCNode.IntervalOfFlash = 1000;
                    ModulForm = new FADP1701VX(fPLCNode, fSerialPLC);
                    break;
                default:
                    break;
            }
            if (ModulForm != null)
            {
                ModulForm.FormClosed += ModulForm_FormClosed;
                ((LModuleSetTool)ModulForm).SetParent(groupBoxPLCInfo);
            }
        }

        private void ModulForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fSerialPLC.ClearAllPLCNode();
            ModulForm = null;
        }

        private void comboBoxPLCType_SelectedIndexChanged(object sender, EventArgs e)
        {            
                buttonOpenPLC.Enabled = (comboBoxPLCType.SelectedIndex >= 0);
        }

        private void FModeulSetTools_FormClosing(object sender, FormClosingEventArgs e)
        {
                fSerialPLC.ClearAllPLCNode();
        }

        private void numericUpDownDestPLCAddress_ValueChanged(object sender, EventArgs e)
        {
            labelDestAddress.Text = "0x" + ((int)numericUpDownDestPLCAddress.Value).ToString("X2");
        }
    }
}
