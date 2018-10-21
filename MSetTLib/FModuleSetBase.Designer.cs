namespace MSetTLib
{
    partial class FModuleSetBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "0x0001",
            "65535",
            "0xAC15",
            "0xA3",
            "0x6B"}, -1);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelErrorCode = new System.Windows.Forms.Label();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelModbusAddress = new System.Windows.Forms.Label();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.textBoxPLCSN = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabelPLCAddress = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.listViewRegValue = new System.Windows.Forms.ListView();
            this.splitContainerReg = new System.Windows.Forms.SplitContainer();
            this.fDeamon = new System.Windows.Forms.Timer(this.components);
            this.panelRegValue = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRegAddress = new System.Windows.Forms.Label();
            this.labelRegValue_10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRegValue_16 = new System.Windows.Forms.Label();
            this.buttonSetRegValue = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReg)).BeginInit();
            this.splitContainerReg.Panel1.SuspendLayout();
            this.splitContainerReg.Panel2.SuspendLayout();
            this.splitContainerReg.SuspendLayout();
            this.panelRegValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Address";
            this.columnHeader1.Width = 65;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value(10)";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 70;
            // 
            // labelErrorCode
            // 
            this.labelErrorCode.BackColor = System.Drawing.Color.White;
            this.labelErrorCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelErrorCode.Location = new System.Drawing.Point(323, 48);
            this.labelErrorCode.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelErrorCode.Name = "labelErrorCode";
            this.labelErrorCode.Size = new System.Drawing.Size(114, 23);
            this.labelErrorCode.TabIndex = 36;
            this.labelErrorCode.Text = "0x0000";
            this.labelErrorCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value(HEX)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.labelModbusAddress);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 38);
            this.panel1.TabIndex = 19;
            // 
            // labelModbusAddress
            // 
            this.labelModbusAddress.BackColor = System.Drawing.Color.White;
            this.labelModbusAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelModbusAddress.Location = new System.Drawing.Point(3, 8);
            this.labelModbusAddress.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelModbusAddress.Name = "labelModbusAddress";
            this.labelModbusAddress.Size = new System.Drawing.Size(114, 33);
            this.labelModbusAddress.TabIndex = 21;
            this.labelModbusAddress.Text = "Address：";
            this.labelModbusAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "V(H)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 55;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "序列号：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "V(L)";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 55;
            // 
            // textBoxPLCSN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxPLCSN, 3);
            this.textBoxPLCSN.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPLCSN.Location = new System.Drawing.Point(101, 73);
            this.textBoxPLCSN.Margin = new System.Windows.Forms.Padding(1, 1, 3, 4);
            this.textBoxPLCSN.Name = "textBoxPLCSN";
            this.textBoxPLCSN.ReadOnly = true;
            this.textBoxPLCSN.Size = new System.Drawing.Size(336, 26);
            this.textBoxPLCSN.TabIndex = 21;
            this.textBoxPLCSN.DoubleClick += new System.EventHandler(this.textBoxPLCSN_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelPLCAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelErrorCode, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPLCSN, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 152);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "本机地址：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelPLCAddress
            // 
            this.linkLabelPLCAddress.BackColor = System.Drawing.Color.White;
            this.linkLabelPLCAddress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelPLCAddress.Location = new System.Drawing.Point(101, 48);
            this.linkLabelPLCAddress.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.linkLabelPLCAddress.Name = "linkLabelPLCAddress";
            this.linkLabelPLCAddress.Size = new System.Drawing.Size(116, 23);
            this.linkLabelPLCAddress.TabIndex = 25;
            this.linkLabelPLCAddress.TabStop = true;
            this.linkLabelPLCAddress.Text = "23";
            this.linkLabelPLCAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLabelPLCAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPLCAddress_LinkClicked);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(223, 48);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 23);
            this.label16.TabIndex = 36;
            this.label16.Text = "错误代码：";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listViewRegValue
            // 
            this.listViewRegValue.BackColor = System.Drawing.Color.White;
            this.listViewRegValue.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listViewRegValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewRegValue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewRegValue.FullRowSelect = true;
            this.listViewRegValue.GridLines = true;
            this.listViewRegValue.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listViewRegValue.Location = new System.Drawing.Point(0, 20);
            this.listViewRegValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewRegValue.MultiSelect = false;
            this.listViewRegValue.Name = "listViewRegValue";
            this.listViewRegValue.Size = new System.Drawing.Size(480, 343);
            this.listViewRegValue.TabIndex = 16;
            this.listViewRegValue.UseCompatibleStateImageBehavior = false;
            this.listViewRegValue.View = System.Windows.Forms.View.Details;
            this.listViewRegValue.SelectedIndexChanged += new System.EventHandler(this.listViewRegValue_SelectedIndexChanged);
            // 
            // splitContainerReg
            // 
            this.splitContainerReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerReg.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainerReg.IsSplitterFixed = true;
            this.splitContainerReg.Location = new System.Drawing.Point(0, 0);
            this.splitContainerReg.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerReg.Name = "splitContainerReg";
            this.splitContainerReg.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerReg.Panel1
            // 
            this.splitContainerReg.Panel1.Controls.Add(this.tableLayoutPanel1);
            this.splitContainerReg.Panel1MinSize = 0;
            // 
            // splitContainerReg.Panel2
            // 
            this.splitContainerReg.Panel2.Controls.Add(this.listViewRegValue);
            this.splitContainerReg.Panel2.Controls.Add(this.panelRegValue);
            this.splitContainerReg.Size = new System.Drawing.Size(480, 521);
            this.splitContainerReg.SplitterDistance = 152;
            this.splitContainerReg.SplitterWidth = 6;
            this.splitContainerReg.TabIndex = 5;
            // 
            // fDeamon
            // 
            this.fDeamon.Enabled = true;
            this.fDeamon.Interval = 10;
            this.fDeamon.Tick += new System.EventHandler(this.fDeamon_Tick);
            // 
            // panelRegValue
            // 
            this.panelRegValue.Controls.Add(this.buttonSetRegValue);
            this.panelRegValue.Controls.Add(this.labelRegValue_16);
            this.panelRegValue.Controls.Add(this.label2);
            this.panelRegValue.Controls.Add(this.labelRegValue_10);
            this.panelRegValue.Controls.Add(this.labelRegAddress);
            this.panelRegValue.Controls.Add(this.label1);
            this.panelRegValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegValue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelRegValue.Location = new System.Drawing.Point(0, 0);
            this.panelRegValue.Name = "panelRegValue";
            this.panelRegValue.Size = new System.Drawing.Size(480, 20);
            this.panelRegValue.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // labelRegAddress
            // 
            this.labelRegAddress.Location = new System.Drawing.Point(64, 1);
            this.labelRegAddress.Name = "labelRegAddress";
            this.labelRegAddress.Size = new System.Drawing.Size(56, 14);
            this.labelRegAddress.TabIndex = 1;
            this.labelRegAddress.Text = "0x0001";
            // 
            // labelRegValue_10
            // 
            this.labelRegValue_10.Location = new System.Drawing.Point(174, 1);
            this.labelRegValue_10.Name = "labelRegValue_10";
            this.labelRegValue_10.Size = new System.Drawing.Size(56, 14);
            this.labelRegValue_10.TabIndex = 2;
            this.labelRegValue_10.Text = "65535";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value:";
            // 
            // labelRegValue_16
            // 
            this.labelRegValue_16.Location = new System.Drawing.Point(236, 1);
            this.labelRegValue_16.Name = "labelRegValue_16";
            this.labelRegValue_16.Size = new System.Drawing.Size(56, 14);
            this.labelRegValue_16.TabIndex = 4;
            this.labelRegValue_16.Text = "0x5548";
            // 
            // buttonSetRegValue
            // 
            this.buttonSetRegValue.Location = new System.Drawing.Point(289, -1);
            this.buttonSetRegValue.Name = "buttonSetRegValue";
            this.buttonSetRegValue.Size = new System.Drawing.Size(75, 18);
            this.buttonSetRegValue.TabIndex = 5;
            this.buttonSetRegValue.Text = "SetValue";
            this.buttonSetRegValue.UseVisualStyleBackColor = true;
            this.buttonSetRegValue.Click += new System.EventHandler(this.buttonSetRegValue_Click);
            // 
            // FModuleSetBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 521);
            this.Controls.Add(this.splitContainerReg);
            this.Name = "FModuleSetBase";
            this.Text = "FModuleSetBase";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainerReg.Panel1.ResumeLayout(false);
            this.splitContainerReg.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReg)).EndInit();
            this.splitContainerReg.ResumeLayout(false);
            this.panelRegValue.ResumeLayout(false);
            this.panelRegValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label labelErrorCode;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabelPLCAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPLCSN;
        private System.Windows.Forms.Label labelModbusAddress;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView listViewRegValue;
        private System.Windows.Forms.SplitContainer splitContainerReg;
        private System.Windows.Forms.Timer fDeamon;
        private System.Windows.Forms.Panel panelRegValue;
        private System.Windows.Forms.Label labelRegValue_16;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRegValue_10;
        private System.Windows.Forms.Label labelRegAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSetRegValue;
    }
}