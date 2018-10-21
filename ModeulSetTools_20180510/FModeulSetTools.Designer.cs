namespace ModeulSetTools
{
    partial class FModeulSetTools
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FModeulSetTools));
            this.groupBoxConfig = new System.Windows.Forms.GroupBox();
            this.panelBusManager = new System.Windows.Forms.Panel();
            this.numericUpDownDestPLCAddress = new System.Windows.Forms.NumericUpDown();
            this.comboBoxPLCType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOpenPLC = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxBusInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStarStopBus = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.fDeamon = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerPLCManager = new System.Windows.Forms.SplitContainer();
            this.groupBoxPLCInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxRunLog = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelDestAddress = new System.Windows.Forms.Label();
            this.groupBoxConfig.SuspendLayout();
            this.panelBusManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestPLCAddress)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPLCManager)).BeginInit();
            this.splitContainerPLCManager.Panel1.SuspendLayout();
            this.splitContainerPLCManager.Panel2.SuspendLayout();
            this.splitContainerPLCManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConfig
            // 
            this.groupBoxConfig.Controls.Add(this.panelBusManager);
            this.groupBoxConfig.Controls.Add(this.panel1);
            this.groupBoxConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxConfig.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxConfig.Location = new System.Drawing.Point(0, 0);
            this.groupBoxConfig.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxConfig.Name = "groupBoxConfig";
            this.groupBoxConfig.Padding = new System.Windows.Forms.Padding(5);
            this.groupBoxConfig.Size = new System.Drawing.Size(1018, 69);
            this.groupBoxConfig.TabIndex = 1;
            this.groupBoxConfig.TabStop = false;
            this.groupBoxConfig.Text = "Config";
            // 
            // panelBusManager
            // 
            this.panelBusManager.Controls.Add(this.labelDestAddress);
            this.panelBusManager.Controls.Add(this.numericUpDownDestPLCAddress);
            this.panelBusManager.Controls.Add(this.comboBoxPLCType);
            this.panelBusManager.Controls.Add(this.label2);
            this.panelBusManager.Controls.Add(this.buttonOpenPLC);
            this.panelBusManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusManager.Location = new System.Drawing.Point(539, 24);
            this.panelBusManager.Name = "panelBusManager";
            this.panelBusManager.Size = new System.Drawing.Size(474, 40);
            this.panelBusManager.TabIndex = 7;
            // 
            // numericUpDownDestPLCAddress
            // 
            this.numericUpDownDestPLCAddress.Location = new System.Drawing.Point(275, 8);
            this.numericUpDownDestPLCAddress.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownDestPLCAddress.Name = "numericUpDownDestPLCAddress";
            this.numericUpDownDestPLCAddress.Size = new System.Drawing.Size(54, 26);
            this.numericUpDownDestPLCAddress.TabIndex = 9;
            this.toolTip1.SetToolTip(this.numericUpDownDestPLCAddress, "目标PLC地址");
            this.numericUpDownDestPLCAddress.ValueChanged += new System.EventHandler(this.numericUpDownDestPLCAddress_ValueChanged);
            // 
            // comboBoxPLCType
            // 
            this.comboBoxPLCType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPLCType.FormattingEnabled = true;
            this.comboBoxPLCType.Items.AddRange(new object[] {
            "基础模块PLC",
            "C8051F350模块",
            "ADP1701VX"});
            this.comboBoxPLCType.Location = new System.Drawing.Point(78, 7);
            this.comboBoxPLCType.Name = "comboBoxPLCType";
            this.comboBoxPLCType.Size = new System.Drawing.Size(191, 28);
            this.comboBoxPLCType.TabIndex = 8;
            this.comboBoxPLCType.SelectedIndexChanged += new System.EventHandler(this.comboBoxPLCType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "PLCType";
            // 
            // buttonOpenPLC
            // 
            this.buttonOpenPLC.Enabled = false;
            this.buttonOpenPLC.Location = new System.Drawing.Point(376, 7);
            this.buttonOpenPLC.Name = "buttonOpenPLC";
            this.buttonOpenPLC.Size = new System.Drawing.Size(91, 29);
            this.buttonOpenPLC.TabIndex = 6;
            this.buttonOpenPLC.Text = "OpenPLC";
            this.buttonOpenPLC.UseVisualStyleBackColor = true;
            this.buttonOpenPLC.Click += new System.EventHandler(this.buttonOpenPLC_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxBusInfo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonStarStopBus);
            this.panel1.Controls.Add(this.buttonConfig);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(5, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 40);
            this.panel1.TabIndex = 8;
            // 
            // textBoxBusInfo
            // 
            this.textBoxBusInfo.Location = new System.Drawing.Point(70, 7);
            this.textBoxBusInfo.Name = "textBoxBusInfo";
            this.textBoxBusInfo.ReadOnly = true;
            this.textBoxBusInfo.Size = new System.Drawing.Size(221, 26);
            this.textBoxBusInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BusInfo";
            // 
            // buttonStarStopBus
            // 
            this.buttonStarStopBus.Location = new System.Drawing.Point(388, 6);
            this.buttonStarStopBus.Name = "buttonStarStopBus";
            this.buttonStarStopBus.Size = new System.Drawing.Size(87, 29);
            this.buttonStarStopBus.TabIndex = 5;
            this.buttonStarStopBus.Text = "StarBus";
            this.buttonStarStopBus.UseVisualStyleBackColor = true;
            this.buttonStarStopBus.Click += new System.EventHandler(this.buttonStarStopBus_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(297, 6);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(87, 29);
            this.buttonConfig.TabIndex = 4;
            this.buttonConfig.Text = "Config";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // fDeamon
            // 
            this.fDeamon.Enabled = true;
            this.fDeamon.Tick += new System.EventHandler(this.fDeamon_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1018, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel1.Text = "BusInfo";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(150, 17);
            this.toolStripStatusLabel2.Text = "Tick";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainerPLCManager
            // 
            this.splitContainerPLCManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPLCManager.Location = new System.Drawing.Point(0, 69);
            this.splitContainerPLCManager.Name = "splitContainerPLCManager";
            // 
            // splitContainerPLCManager.Panel1
            // 
            this.splitContainerPLCManager.Panel1.Controls.Add(this.groupBoxPLCInfo);
            // 
            // splitContainerPLCManager.Panel2
            // 
            this.splitContainerPLCManager.Panel2.Controls.Add(this.groupBoxRunLog);
            this.splitContainerPLCManager.Size = new System.Drawing.Size(1018, 483);
            this.splitContainerPLCManager.SplitterDistance = 521;
            this.splitContainerPLCManager.TabIndex = 4;
            this.splitContainerPLCManager.Visible = false;
            // 
            // groupBoxPLCInfo
            // 
            this.groupBoxPLCInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPLCInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxPLCInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPLCInfo.Name = "groupBoxPLCInfo";
            this.groupBoxPLCInfo.Size = new System.Drawing.Size(521, 483);
            this.groupBoxPLCInfo.TabIndex = 1;
            this.groupBoxPLCInfo.TabStop = false;
            this.groupBoxPLCInfo.Text = "模块寄存器管理";
            // 
            // groupBoxRunLog
            // 
            this.groupBoxRunLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRunLog.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxRunLog.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRunLog.Name = "groupBoxRunLog";
            this.groupBoxRunLog.Size = new System.Drawing.Size(493, 483);
            this.groupBoxRunLog.TabIndex = 1;
            this.groupBoxRunLog.TabStop = false;
            this.groupBoxRunLog.Text = "运行日志";
            // 
            // labelDestAddress
            // 
            this.labelDestAddress.AutoSize = true;
            this.labelDestAddress.Location = new System.Drawing.Point(332, 11);
            this.labelDestAddress.Name = "labelDestAddress";
            this.labelDestAddress.Size = new System.Drawing.Size(40, 20);
            this.labelDestAddress.TabIndex = 10;
            this.labelDestAddress.Text = "0x00";
            // 
            // FModeulSetTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 574);
            this.Controls.Add(this.splitContainerPLCManager);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FModeulSetTools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "模块配置工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FModeulSetTools_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FModeulSetTools_Demo_FormClosed);
            this.groupBoxConfig.ResumeLayout(false);
            this.panelBusManager.ResumeLayout(false);
            this.panelBusManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDestPLCAddress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainerPLCManager.Panel1.ResumeLayout(false);
            this.splitContainerPLCManager.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPLCManager)).EndInit();
            this.splitContainerPLCManager.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfig;
        private System.Windows.Forms.Button buttonStarStopBus;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.TextBox textBoxBusInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer fDeamon;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.SplitContainer splitContainerPLCManager;
        private System.Windows.Forms.Panel panelBusManager;
        private System.Windows.Forms.Button buttonOpenPLC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBoxPLCType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPLCInfo;
        private System.Windows.Forms.GroupBox groupBoxRunLog;
        private System.Windows.Forms.NumericUpDown numericUpDownDestPLCAddress;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelDestAddress;
    }
}

