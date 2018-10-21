using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZLFMSTInputDialog
{
    public partial class Input_F350_ADCSet : Form
    {
        public int ADCSetValue { get; set; }
        public Input_F350_ADCSet(int fADCSetValue)
        {
            InitializeComponent();
            ADCSetValue = fADCSetValue;
            int fADC0CN = (ADCSetValue >> 8) & 0xFF;
            // AD0POL
            if (((fADC0CN >> 4) & 1) == 0)
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
            // AD0GN
            if ((fADC0CN & 0x0F)< comboBox1.Items.Count)
                comboBox1.SelectedIndex = fADC0CN & 0x0F;

            int fADC0MUX = ADCSetValue & 0xFF;
            switch ((fADC0MUX>>4)&0x0F)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    comboBox2.SelectedIndex = (fADC0MUX >> 4) & 0x0F;
                    break;
                case 0x0F:
                    comboBox2.SelectedIndex = 9;
                    break;
                default:
                    comboBox2.SelectedIndex = 8;
                    break;
            }
            switch (fADC0MUX  & 0x0F)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    comboBox3.SelectedIndex = fADC0MUX & 0x0F;
                    break;
                case 0x0F:
                    comboBox3.SelectedIndex = 9;
                    break;
                default:
                    comboBox3.SelectedIndex = 8;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int fADC0CN = 0;
            if (radioButton2.Checked)
            {
                fADC0CN = 1;
                fADC0CN <<= 4;
            }
            fADC0CN |= (comboBox1.SelectedIndex & 0x0F);
            int fADC0MUX = 0;
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    fADC0MUX = comboBox2.SelectedIndex;
                    break;
                case 9:
                    fADC0MUX = 0xF;
                    break;
                default:
                    fADC0MUX = 0x9;
                    break;
            }
            fADC0MUX <<= 4;
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                    fADC0MUX |= comboBox3.SelectedIndex;
                    break;
                case 9:
                    fADC0MUX |= 0xF;
                    break;
                default:
                    fADC0MUX |= 0x9;
                    break;
            }
            ADCSetValue = (fADC0CN << 8) | fADC0MUX;
            this.DialogResult = DialogResult.OK;
            Close();
        }

        static public bool InputADCSetBox(ref int fADCSetValue)
        {
            Input_F350_ADCSet fInputF350ADCSet = new Input_F350_ADCSet(fADCSetValue);
            fInputF350ADCSet.ShowDialog();
            if (fInputF350ADCSet.DialogResult== DialogResult.OK)
            {
                fADCSetValue = fInputF350ADCSet.ADCSetValue;
                return true;
            }
            return false;
        }
    }
}
