using LModBusRTU;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C8051F350_YBExt_Manager
{
    public partial class Input_F350_PlanSet : Form
    {
        private F350YBExtPLC fF350YBExtPLC { get; set; }
        public Input_F350_PlanSet(F350YBExtPLC fF350YBExtPLCX)
        {
            InitializeComponent();
            fF350YBExtPLC = fF350YBExtPLCX;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked || radioButton2.Checked)
                &&(fF350YBExtPLC != null)&& fF350YBExtPLC.PLCActive())
            {
                if (radioButton1.Checked)
                    fF350YBExtPLC.SetPLCRunPlan(1);
                if (radioButton2.Checked)
                    fF350YBExtPLC.SetPLCRunPlan(2);

                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        public static bool InputF350SetPlan(F350YBExtPLC fF350YBExtPLCX)
        {
            Input_F350_PlanSet fInputPlanSet = new Input_F350_PlanSet(fF350YBExtPLCX);
            fInputPlanSet.ShowDialog();
            return fInputPlanSet.DialogResult == DialogResult.OK;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                textBox1.Text = "所有通道对应AIN0.X端口，单极性测量，PGA增益=1，输入负为AGND,快速测量模式,通道2为差分方式测量片上温度温度，PGA增益=32。";
            if (radioButton2.Checked)
                textBox1.Text = "所有通道对应AIN0.X端口，双极性测量，PGA增益=32，输入负为AIN0.7，慢速测量模式，通道2为测量AIN0.7专用平衡片上的绝对电压，PGA增益=1。";
        }
    }
}
