namespace ADP1701VX_Manager
{
    partial class FADP1701VX
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "0x0001",
            "65535",
            "0xAC15",
            "0xA3",
            "0x6B"}, -1);
            this.fDeamon = new System.Windows.Forms.Timer(this.components);
            this.checkBoxSetADCSpeed = new System.Windows.Forms.CheckBox();
            this.checkBoxSetI2CPort = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabelPLCAddress = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelT8Set = new System.Windows.Forms.LinkLabel();
            this.checkBoxSetT2Value = new System.Windows.Forms.CheckBox();
            this.linkLabelT7Set = new System.Windows.Forms.LinkLabel();
            this.linkLabelT5Set = new System.Windows.Forms.LinkLabel();
            this.linkLabelT4Set = new System.Windows.Forms.LinkLabel();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20ADCResultCount = new System.Windows.Forms.Label();
            this.listViewRegValue = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.linkLabelT6Set = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelErrorCode = new System.Windows.Forms.Label();
            this.labelT2Value = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelT8Value = new System.Windows.Forms.Label();
            this.labelT7Value = new System.Windows.Forms.Label();
            this.labelT6Value = new System.Windows.Forms.Label();
            this.labelT5Value = new System.Windows.Forms.Label();
            this.labelT4Value = new System.Windows.Forms.Label();
            this.labelT3Value = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.linkLabelT3Set = new System.Windows.Forms.LinkLabel();
            this.labelVRef = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.labelModbusAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPLCSN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainerReg = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReg)).BeginInit();
            this.splitContainerReg.Panel1.SuspendLayout();
            this.splitContainerReg.Panel2.SuspendLayout();
            this.splitContainerReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // fDeamon
            // 
            this.fDeamon.Enabled = true;
            this.fDeamon.Interval = 10;
            // 
            // checkBoxSetADCSpeed
            // 
            this.checkBoxSetADCSpeed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSetADCSpeed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxSetADCSpeed.Location = new System.Drawing.Point(111, 4);
            this.checkBoxSetADCSpeed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSetADCSpeed.Name = "checkBoxSetADCSpeed";
            this.checkBoxSetADCSpeed.Size = new System.Drawing.Size(102, 20);
            this.checkBoxSetADCSpeed.TabIndex = 17;
            this.checkBoxSetADCSpeed.Text = "ADC高速模式";
            this.checkBoxSetADCSpeed.UseVisualStyleBackColor = true;
            // 
            // checkBoxSetI2CPort
            // 
            this.checkBoxSetI2CPort.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSetI2CPort.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxSetI2CPort.Location = new System.Drawing.Point(3, 4);
            this.checkBoxSetI2CPort.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSetI2CPort.Name = "checkBoxSetI2CPort";
            this.checkBoxSetI2CPort.Size = new System.Drawing.Size(102, 20);
            this.checkBoxSetI2CPort.TabIndex = 0;
            this.checkBoxSetI2CPort.Text = "I2C端口反接";
            this.checkBoxSetI2CPort.UseVisualStyleBackColor = true;
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
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "通道3设置：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 223);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "通道8设置：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 198);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "通道7设置：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "通道6设置：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "通道5设置：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "通道4设置：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelT8Set
            // 
            this.linkLabelT8Set.BackColor = System.Drawing.Color.White;
            this.linkLabelT8Set.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelT8Set.Location = new System.Drawing.Point(101, 223);
            this.linkLabelT8Set.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.linkLabelT8Set.Name = "linkLabelT8Set";
            this.linkLabelT8Set.Size = new System.Drawing.Size(116, 23);
            this.linkLabelT8Set.TabIndex = 27;
            this.linkLabelT8Set.TabStop = true;
            this.linkLabelT8Set.Text = "0x0000";
            this.linkLabelT8Set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxSetT2Value
            // 
            this.checkBoxSetT2Value.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxSetT2Value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBoxSetT2Value.Location = new System.Drawing.Point(219, 4);
            this.checkBoxSetT2Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxSetT2Value.Name = "checkBoxSetT2Value";
            this.checkBoxSetT2Value.Size = new System.Drawing.Size(102, 20);
            this.checkBoxSetT2Value.TabIndex = 18;
            this.checkBoxSetT2Value.Text = "T2为平衡片";
            this.toolTip1.SetToolTip(this.checkBoxSetT2Value, "选中时为AIN0.7的绝对电压，否则片上温度");
            this.checkBoxSetT2Value.UseVisualStyleBackColor = true;
            // 
            // linkLabelT7Set
            // 
            this.linkLabelT7Set.BackColor = System.Drawing.Color.White;
            this.linkLabelT7Set.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelT7Set.Location = new System.Drawing.Point(101, 198);
            this.linkLabelT7Set.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.linkLabelT7Set.Name = "linkLabelT7Set";
            this.linkLabelT7Set.Size = new System.Drawing.Size(116, 23);
            this.linkLabelT7Set.TabIndex = 27;
            this.linkLabelT7Set.TabStop = true;
            this.linkLabelT7Set.Text = "0x0000";
            this.linkLabelT7Set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabelT5Set
            // 
            this.linkLabelT5Set.BackColor = System.Drawing.Color.White;
            this.linkLabelT5Set.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelT5Set.Location = new System.Drawing.Point(101, 148);
            this.linkLabelT5Set.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.linkLabelT5Set.Name = "linkLabelT5Set";
            this.linkLabelT5Set.Size = new System.Drawing.Size(116, 23);
            this.linkLabelT5Set.TabIndex = 27;
            this.linkLabelT5Set.TabStop = true;
            this.linkLabelT5Set.Text = "0x0000";
            this.linkLabelT5Set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabelT4Set
            // 
            this.linkLabelT4Set.BackColor = System.Drawing.Color.White;
            this.linkLabelT4Set.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelT4Set.Location = new System.Drawing.Point(101, 123);
            this.linkLabelT4Set.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.linkLabelT4Set.Name = "linkLabelT4Set";
            this.linkLabelT4Set.Size = new System.Drawing.Size(116, 23);
            this.linkLabelT4Set.TabIndex = 27;
            this.linkLabelT4Set.TabStop = true;
            this.linkLabelT4Set.Text = "0x0000";
            this.linkLabelT4Set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(3, 73);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 23);
            this.label16.TabIndex = 36;
            this.label16.Text = "错误代码：";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(3, 248);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 23);
            this.label19.TabIndex = 37;
            this.label19.Text = "测量次数：";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20ADCResultCount
            // 
            this.label20ADCResultCount.BackColor = System.Drawing.Color.White;
            this.label20ADCResultCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20ADCResultCount.Location = new System.Drawing.Point(103, 248);
            this.label20ADCResultCount.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label20ADCResultCount.Name = "label20ADCResultCount";
            this.label20ADCResultCount.Size = new System.Drawing.Size(117, 23);
            this.label20ADCResultCount.TabIndex = 38;
            this.label20ADCResultCount.Text = "0";
            this.label20ADCResultCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            listViewItem2});
            this.listViewRegValue.Location = new System.Drawing.Point(0, 0);
            this.listViewRegValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewRegValue.MultiSelect = false;
            this.listViewRegValue.Name = "listViewRegValue";
            this.listViewRegValue.Size = new System.Drawing.Size(443, 150);
            this.listViewRegValue.TabIndex = 16;
            this.listViewRegValue.UseCompatibleStateImageBehavior = false;
            this.listViewRegValue.View = System.Windows.Forms.View.Details;
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value(HEX)";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "V(H)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "V(L)";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 55;
            // 
            // linkLabelT6Set
            // 
            this.linkLabelT6Set.BackColor = System.Drawing.Color.White;
            this.linkLabelT6Set.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelT6Set.Location = new System.Drawing.Point(101, 173);
            this.linkLabelT6Set.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.linkLabelT6Set.Name = "linkLabelT6Set";
            this.linkLabelT6Set.Size = new System.Drawing.Size(116, 23);
            this.linkLabelT6Set.TabIndex = 27;
            this.linkLabelT6Set.TabStop = true;
            this.linkLabelT6Set.Text = "0x0000";
            this.linkLabelT6Set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.checkBoxSetT2Value, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxSetADCSpeed, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.checkBoxSetI2CPort, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(434, 57);
            this.tableLayoutPanel2.TabIndex = 18;
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
            this.tableLayoutPanel1.Controls.Add(this.labelErrorCode, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelT2Value, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelT8Value, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelT7Value, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelT6Value, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelT5Value, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelT4Value, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelT3Value, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelT3Set, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelVRef, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPLCSN, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelPLCAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelT8Set, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelT7Set, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelT6Set, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelT5Set, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelT4Set, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label20ADCResultCount, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 15;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 7F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 368);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelErrorCode
            // 
            this.labelErrorCode.BackColor = System.Drawing.Color.White;
            this.labelErrorCode.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelErrorCode.Location = new System.Drawing.Point(103, 73);
            this.labelErrorCode.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.labelErrorCode.Name = "labelErrorCode";
            this.labelErrorCode.Size = new System.Drawing.Size(114, 23);
            this.labelErrorCode.TabIndex = 36;
            this.labelErrorCode.Text = "0x0000";
            this.labelErrorCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelT2Value
            // 
            this.labelT2Value.BackColor = System.Drawing.Color.White;
            this.labelT2Value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelT2Value.Location = new System.Drawing.Point(323, 73);
            this.labelT2Value.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelT2Value.Name = "labelT2Value";
            this.labelT2Value.Size = new System.Drawing.Size(117, 23);
            this.labelT2Value.TabIndex = 35;
            this.labelT2Value.Text = "100uV";
            this.labelT2Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(223, 73);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 23);
            this.label17.TabIndex = 35;
            this.label17.Text = "通道2结果：";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelT8Value
            // 
            this.labelT8Value.BackColor = System.Drawing.Color.White;
            this.labelT8Value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelT8Value.Location = new System.Drawing.Point(323, 223);
            this.labelT8Value.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelT8Value.Name = "labelT8Value";
            this.labelT8Value.Size = new System.Drawing.Size(117, 23);
            this.labelT8Value.TabIndex = 34;
            this.labelT8Value.Text = "100uV";
            this.labelT8Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelT7Value
            // 
            this.labelT7Value.BackColor = System.Drawing.Color.White;
            this.labelT7Value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelT7Value.Location = new System.Drawing.Point(323, 198);
            this.labelT7Value.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelT7Value.Name = "labelT7Value";
            this.labelT7Value.Size = new System.Drawing.Size(117, 23);
            this.labelT7Value.TabIndex = 34;
            this.labelT7Value.Text = "100uV";
            this.labelT7Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelT6Value
            // 
            this.labelT6Value.BackColor = System.Drawing.Color.White;
            this.labelT6Value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelT6Value.Location = new System.Drawing.Point(323, 173);
            this.labelT6Value.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelT6Value.Name = "labelT6Value";
            this.labelT6Value.Size = new System.Drawing.Size(117, 23);
            this.labelT6Value.TabIndex = 34;
            this.labelT6Value.Text = "100uV";
            this.labelT6Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelT5Value
            // 
            this.labelT5Value.BackColor = System.Drawing.Color.White;
            this.labelT5Value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelT5Value.Location = new System.Drawing.Point(323, 148);
            this.labelT5Value.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelT5Value.Name = "labelT5Value";
            this.labelT5Value.Size = new System.Drawing.Size(117, 23);
            this.labelT5Value.TabIndex = 34;
            this.labelT5Value.Text = "100uV";
            this.labelT5Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelT4Value
            // 
            this.labelT4Value.BackColor = System.Drawing.Color.White;
            this.labelT4Value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelT4Value.Location = new System.Drawing.Point(323, 123);
            this.labelT4Value.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelT4Value.Name = "labelT4Value";
            this.labelT4Value.Size = new System.Drawing.Size(117, 23);
            this.labelT4Value.TabIndex = 34;
            this.labelT4Value.Text = "100uV";
            this.labelT4Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelT3Value
            // 
            this.labelT3Value.BackColor = System.Drawing.Color.White;
            this.labelT3Value.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelT3Value.Location = new System.Drawing.Point(323, 98);
            this.labelT3Value.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelT3Value.Name = "labelT3Value";
            this.labelT3Value.Size = new System.Drawing.Size(117, 23);
            this.labelT3Value.TabIndex = 34;
            this.labelT3Value.Text = "100uV";
            this.labelT3Value.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(223, 223);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 23);
            this.label15.TabIndex = 32;
            this.label15.Text = "通道8结果：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(223, 173);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 23);
            this.label14.TabIndex = 32;
            this.label14.Text = "通道6结果：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(223, 198);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 23);
            this.label13.TabIndex = 32;
            this.label13.Text = "通道7结果：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(223, 148);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 32;
            this.label12.Text = "通道5结果：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(223, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "通道4结果：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(223, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "通道3结果：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // linkLabelT3Set
            // 
            this.linkLabelT3Set.BackColor = System.Drawing.Color.White;
            this.linkLabelT3Set.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.linkLabelT3Set.Location = new System.Drawing.Point(101, 98);
            this.linkLabelT3Set.Margin = new System.Windows.Forms.Padding(1, 1, 3, 1);
            this.linkLabelT3Set.Name = "linkLabelT3Set";
            this.linkLabelT3Set.Size = new System.Drawing.Size(116, 23);
            this.linkLabelT3Set.TabIndex = 26;
            this.linkLabelT3Set.TabStop = true;
            this.linkLabelT3Set.Text = "0x0000";
            this.linkLabelT3Set.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVRef
            // 
            this.labelVRef.BackColor = System.Drawing.Color.White;
            this.labelVRef.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVRef.Location = new System.Drawing.Point(323, 48);
            this.labelVRef.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelVRef.Name = "labelVRef";
            this.labelVRef.Size = new System.Drawing.Size(117, 23);
            this.labelVRef.TabIndex = 33;
            this.labelVRef.Text = "3300mV";
            this.labelVRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(223, 48);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "VRef：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.labelModbusAddress);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 38);
            this.panel1.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(125, 10);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(223, 23);
            this.label18.TabIndex = 23;
            this.label18.Text = "对应ADP1701驱动(20180604)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelModbusAddress
            // 
            this.labelModbusAddress.BackColor = System.Drawing.Color.White;
            this.labelModbusAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelModbusAddress.Location = new System.Drawing.Point(1, 5);
            this.labelModbusAddress.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelModbusAddress.Name = "labelModbusAddress";
            this.labelModbusAddress.Size = new System.Drawing.Size(121, 33);
            this.labelModbusAddress.TabIndex = 21;
            this.labelModbusAddress.Text = "Address：";
            this.labelModbusAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "序列号：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPLCSN
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxPLCSN, 3);
            this.textBoxPLCSN.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxPLCSN.Location = new System.Drawing.Point(101, 273);
            this.textBoxPLCSN.Margin = new System.Windows.Forms.Padding(1, 1, 3, 4);
            this.textBoxPLCSN.Name = "textBoxPLCSN";
            this.textBoxPLCSN.ReadOnly = true;
            this.textBoxPLCSN.Size = new System.Drawing.Size(336, 26);
            this.textBoxPLCSN.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.panel2, 4);
            this.panel2.Controls.Add(this.tableLayoutPanel2);
            this.panel2.Location = new System.Drawing.Point(3, 305);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 57);
            this.panel2.TabIndex = 30;
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
            this.splitContainerReg.Panel1MinSize = 195;
            // 
            // splitContainerReg.Panel2
            // 
            this.splitContainerReg.Panel2.Controls.Add(this.listViewRegValue);
            this.splitContainerReg.Size = new System.Drawing.Size(443, 524);
            this.splitContainerReg.SplitterDistance = 368;
            this.splitContainerReg.SplitterWidth = 6;
            this.splitContainerReg.TabIndex = 5;
            // 
            // FADP1701VX
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(443, 524);
            this.Controls.Add(this.splitContainerReg);
            this.Name = "FADP1701VX";
            this.Text = "FADP1701VX";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainerReg.Panel1.ResumeLayout(false);
            this.splitContainerReg.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReg)).EndInit();
            this.splitContainerReg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer fDeamon;
        private System.Windows.Forms.CheckBox checkBoxSetADCSpeed;
        private System.Windows.Forms.CheckBox checkBoxSetI2CPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabelPLCAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelT8Set;
        private System.Windows.Forms.CheckBox checkBoxSetT2Value;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabelT7Set;
        private System.Windows.Forms.LinkLabel linkLabelT5Set;
        private System.Windows.Forms.LinkLabel linkLabelT4Set;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20ADCResultCount;
        private System.Windows.Forms.ListView listViewRegValue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.LinkLabel linkLabelT6Set;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelErrorCode;
        private System.Windows.Forms.Label labelT2Value;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelT8Value;
        private System.Windows.Forms.Label labelT7Value;
        private System.Windows.Forms.Label labelT6Value;
        private System.Windows.Forms.Label labelT5Value;
        private System.Windows.Forms.Label labelT4Value;
        private System.Windows.Forms.Label labelT3Value;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel linkLabelT3Set;
        private System.Windows.Forms.Label labelVRef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelModbusAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPLCSN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainerReg;
    }
}