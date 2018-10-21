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
            this.label5 = new System.Windows.Forms.Label();
            this.linkLabelPLCAddress = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.labelADCAResultCount = new System.Windows.Forms.Label();
            this.listViewRegValue = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelA17 = new System.Windows.Forms.Label();
            this.labelA16 = new System.Windows.Forms.Label();
            this.labelA15 = new System.Windows.Forms.Label();
            this.labelA14 = new System.Windows.Forms.Label();
            this.labelA13 = new System.Windows.Forms.Label();
            this.labelA12 = new System.Windows.Forms.Label();
            this.labelA11 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelADCBResultCount = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.labelA26 = new System.Windows.Forms.Label();
            this.labelA25 = new System.Windows.Forms.Label();
            this.labelA24 = new System.Windows.Forms.Label();
            this.labelA23 = new System.Windows.Forms.Label();
            this.labelA22 = new System.Windows.Forms.Label();
            this.labelA21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRTCFG = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.labelModbusAddress = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPLCSN = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.labelA27 = new System.Windows.Forms.Label();
            this.labelErrorCode = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelAVRef = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelBVRef = new System.Windows.Forms.Label();
            this.splitContainerReg = new System.Windows.Forms.SplitContainer();
            this.panelRegValue = new System.Windows.Forms.Panel();
            this.buttonSetRegValue = new System.Windows.Forms.Button();
            this.labelRegValue_16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelRegValue_10 = new System.Windows.Forms.Label();
            this.labelRegAddress = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReg)).BeginInit();
            this.splitContainerReg.Panel1.SuspendLayout();
            this.splitContainerReg.Panel2.SuspendLayout();
            this.splitContainerReg.SuspendLayout();
            this.panelRegValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // fDeamon
            // 
            this.fDeamon.Enabled = true;
            this.fDeamon.Interval = 10;
            this.fDeamon.Tick += new System.EventHandler(this.fDeamon_Tick);
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "A12：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(3, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "A17：";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 248);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "A16：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 223);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "A15：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "A14：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "A13：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.Location = new System.Drawing.Point(3, 73);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 23);
            this.label19.TabIndex = 37;
            this.label19.Text = "测量次数A：";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelADCAResultCount
            // 
            this.labelADCAResultCount.BackColor = System.Drawing.Color.White;
            this.labelADCAResultCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelADCAResultCount.Location = new System.Drawing.Point(103, 73);
            this.labelADCAResultCount.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelADCAResultCount.Name = "labelADCAResultCount";
            this.labelADCAResultCount.Size = new System.Drawing.Size(117, 23);
            this.labelADCAResultCount.TabIndex = 38;
            this.labelADCAResultCount.Text = "0";
            this.labelADCAResultCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.listViewRegValue.Size = new System.Drawing.Size(443, 188);
            this.listViewRegValue.TabIndex = 16;
            this.listViewRegValue.UseCompatibleStateImageBehavior = false;
            this.listViewRegValue.View = System.Windows.Forms.View.Details;
            this.listViewRegValue.SelectedIndexChanged += new System.EventHandler(this.listViewRegValue_SelectedIndexChanged);
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.labelA17, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelA16, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelA15, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelA14, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelA13, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelA12, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelA11, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label24, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelADCBResultCount, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelA26, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelA25, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelA24, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelA23, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelA22, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelA21, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.label15, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.label14, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label13, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.label11, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label10, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPLCSN, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.linkLabelPLCAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label17, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.labelA27, 3, 11);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelErrorCode, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelAVRef, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelADCAResultCount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label20, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelBVRef, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 16;
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 330);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelA17
            // 
            this.labelA17.BackColor = System.Drawing.Color.White;
            this.labelA17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA17.Location = new System.Drawing.Point(103, 273);
            this.labelA17.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA17.Name = "labelA17";
            this.labelA17.Size = new System.Drawing.Size(117, 23);
            this.labelA17.TabIndex = 36;
            this.labelA17.Text = "100uV";
            this.labelA17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA16
            // 
            this.labelA16.BackColor = System.Drawing.Color.White;
            this.labelA16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA16.Location = new System.Drawing.Point(103, 248);
            this.labelA16.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA16.Name = "labelA16";
            this.labelA16.Size = new System.Drawing.Size(117, 23);
            this.labelA16.TabIndex = 36;
            this.labelA16.Text = "100uV";
            this.labelA16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA15
            // 
            this.labelA15.BackColor = System.Drawing.Color.White;
            this.labelA15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA15.Location = new System.Drawing.Point(103, 223);
            this.labelA15.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA15.Name = "labelA15";
            this.labelA15.Size = new System.Drawing.Size(117, 23);
            this.labelA15.TabIndex = 36;
            this.labelA15.Text = "100uV";
            this.labelA15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA14
            // 
            this.labelA14.BackColor = System.Drawing.Color.White;
            this.labelA14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA14.Location = new System.Drawing.Point(103, 198);
            this.labelA14.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA14.Name = "labelA14";
            this.labelA14.Size = new System.Drawing.Size(117, 23);
            this.labelA14.TabIndex = 36;
            this.labelA14.Text = "100uV";
            this.labelA14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA13
            // 
            this.labelA13.BackColor = System.Drawing.Color.White;
            this.labelA13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA13.Location = new System.Drawing.Point(103, 173);
            this.labelA13.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA13.Name = "labelA13";
            this.labelA13.Size = new System.Drawing.Size(117, 23);
            this.labelA13.TabIndex = 36;
            this.labelA13.Text = "100uV";
            this.labelA13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA12
            // 
            this.labelA12.BackColor = System.Drawing.Color.White;
            this.labelA12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA12.Location = new System.Drawing.Point(103, 148);
            this.labelA12.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA12.Name = "labelA12";
            this.labelA12.Size = new System.Drawing.Size(117, 23);
            this.labelA12.TabIndex = 36;
            this.labelA12.Text = "100uV";
            this.labelA12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA11
            // 
            this.labelA11.BackColor = System.Drawing.Color.White;
            this.labelA11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA11.Location = new System.Drawing.Point(103, 123);
            this.labelA11.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA11.Name = "labelA11";
            this.labelA11.Size = new System.Drawing.Size(117, 23);
            this.labelA11.TabIndex = 36;
            this.labelA11.Text = "100uV";
            this.labelA11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.Location = new System.Drawing.Point(3, 123);
            this.label24.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 23);
            this.label24.TabIndex = 36;
            this.label24.Text = "A11：";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelADCBResultCount
            // 
            this.labelADCBResultCount.BackColor = System.Drawing.Color.White;
            this.labelADCBResultCount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelADCBResultCount.Location = new System.Drawing.Point(323, 73);
            this.labelADCBResultCount.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelADCBResultCount.Name = "labelADCBResultCount";
            this.labelADCBResultCount.Size = new System.Drawing.Size(117, 23);
            this.labelADCBResultCount.TabIndex = 39;
            this.labelADCBResultCount.Text = "0";
            this.labelADCBResultCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.Location = new System.Drawing.Point(223, 73);
            this.label22.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 23);
            this.label22.TabIndex = 38;
            this.label22.Text = "测量次数B：";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelA26
            // 
            this.labelA26.BackColor = System.Drawing.Color.White;
            this.labelA26.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA26.Location = new System.Drawing.Point(323, 248);
            this.labelA26.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA26.Name = "labelA26";
            this.labelA26.Size = new System.Drawing.Size(117, 23);
            this.labelA26.TabIndex = 34;
            this.labelA26.Text = "100uV";
            this.labelA26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA25
            // 
            this.labelA25.BackColor = System.Drawing.Color.White;
            this.labelA25.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA25.Location = new System.Drawing.Point(323, 223);
            this.labelA25.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA25.Name = "labelA25";
            this.labelA25.Size = new System.Drawing.Size(117, 23);
            this.labelA25.TabIndex = 34;
            this.labelA25.Text = "100uV";
            this.labelA25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA24
            // 
            this.labelA24.BackColor = System.Drawing.Color.White;
            this.labelA24.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA24.Location = new System.Drawing.Point(323, 198);
            this.labelA24.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA24.Name = "labelA24";
            this.labelA24.Size = new System.Drawing.Size(117, 23);
            this.labelA24.TabIndex = 34;
            this.labelA24.Text = "100uV";
            this.labelA24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA23
            // 
            this.labelA23.BackColor = System.Drawing.Color.White;
            this.labelA23.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA23.Location = new System.Drawing.Point(323, 173);
            this.labelA23.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA23.Name = "labelA23";
            this.labelA23.Size = new System.Drawing.Size(117, 23);
            this.labelA23.TabIndex = 34;
            this.labelA23.Text = "100uV";
            this.labelA23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA22
            // 
            this.labelA22.BackColor = System.Drawing.Color.White;
            this.labelA22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA22.Location = new System.Drawing.Point(323, 148);
            this.labelA22.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA22.Name = "labelA22";
            this.labelA22.Size = new System.Drawing.Size(117, 23);
            this.labelA22.TabIndex = 34;
            this.labelA22.Text = "100uV";
            this.labelA22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelA21
            // 
            this.labelA21.BackColor = System.Drawing.Color.White;
            this.labelA21.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA21.Location = new System.Drawing.Point(323, 123);
            this.labelA21.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA21.Name = "labelA21";
            this.labelA21.Size = new System.Drawing.Size(117, 23);
            this.labelA21.TabIndex = 34;
            this.labelA21.Text = "100uV";
            this.labelA21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(223, 248);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 23);
            this.label15.TabIndex = 32;
            this.label15.Text = "A26：";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(223, 198);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 23);
            this.label14.TabIndex = 32;
            this.label14.Text = "A24：";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(223, 223);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 23);
            this.label13.TabIndex = 32;
            this.label13.Text = "A25：";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(223, 173);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 23);
            this.label12.TabIndex = 32;
            this.label12.Text = "A23：";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(223, 148);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 23);
            this.label11.TabIndex = 32;
            this.label11.Text = "A22：";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(223, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 23);
            this.label10.TabIndex = 34;
            this.label10.Text = "A21：";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.SetColumnSpan(this.panel1, 4);
            this.panel1.Controls.Add(this.buttonRTCFG);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.labelModbusAddress);
            this.panel1.Location = new System.Drawing.Point(3, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 38);
            this.panel1.TabIndex = 19;
            // 
            // buttonRTCFG
            // 
            this.buttonRTCFG.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRTCFG.Location = new System.Drawing.Point(353, 10);
            this.buttonRTCFG.Name = "buttonRTCFG";
            this.buttonRTCFG.Size = new System.Drawing.Size(75, 23);
            this.buttonRTCFG.TabIndex = 24;
            this.buttonRTCFG.Text = "RTCFG";
            this.buttonRTCFG.UseVisualStyleBackColor = true;
            this.buttonRTCFG.Click += new System.EventHandler(this.buttonRTCFG_Click);
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
            this.label6.Location = new System.Drawing.Point(3, 298);
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
            this.textBoxPLCSN.Location = new System.Drawing.Point(101, 298);
            this.textBoxPLCSN.Margin = new System.Windows.Forms.Padding(1, 1, 3, 4);
            this.textBoxPLCSN.Name = "textBoxPLCSN";
            this.textBoxPLCSN.ReadOnly = true;
            this.textBoxPLCSN.Size = new System.Drawing.Size(336, 26);
            this.textBoxPLCSN.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.Location = new System.Drawing.Point(223, 273);
            this.label17.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(97, 23);
            this.label17.TabIndex = 35;
            this.label17.Text = "A27：";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelA27
            // 
            this.labelA27.BackColor = System.Drawing.Color.White;
            this.labelA27.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelA27.Location = new System.Drawing.Point(323, 273);
            this.labelA27.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelA27.Name = "labelA27";
            this.labelA27.Size = new System.Drawing.Size(117, 23);
            this.labelA27.TabIndex = 35;
            this.labelA27.Text = "100uV";
            this.labelA27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(3, 98);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 32;
            this.label9.Text = "VRefA：";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAVRef
            // 
            this.labelAVRef.BackColor = System.Drawing.Color.White;
            this.labelAVRef.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAVRef.Location = new System.Drawing.Point(103, 98);
            this.labelAVRef.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelAVRef.Name = "labelAVRef";
            this.labelAVRef.Size = new System.Drawing.Size(117, 23);
            this.labelAVRef.TabIndex = 33;
            this.labelAVRef.Text = "3300mV";
            this.labelAVRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label20.Location = new System.Drawing.Point(223, 98);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 23);
            this.label20.TabIndex = 33;
            this.label20.Text = "VRefB：";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBVRef
            // 
            this.labelBVRef.BackColor = System.Drawing.Color.White;
            this.labelBVRef.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBVRef.Location = new System.Drawing.Point(323, 98);
            this.labelBVRef.Margin = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.labelBVRef.Name = "labelBVRef";
            this.labelBVRef.Size = new System.Drawing.Size(117, 23);
            this.labelBVRef.TabIndex = 34;
            this.labelBVRef.Text = "3300mV";
            this.labelBVRef.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.splitContainerReg.Panel2.Controls.Add(this.panelRegValue);
            this.splitContainerReg.Panel2.Controls.Add(this.listViewRegValue);
            this.splitContainerReg.Size = new System.Drawing.Size(443, 524);
            this.splitContainerReg.SplitterDistance = 330;
            this.splitContainerReg.SplitterWidth = 6;
            this.splitContainerReg.TabIndex = 5;
            // 
            // panelRegValue
            // 
            this.panelRegValue.Controls.Add(this.buttonSetRegValue);
            this.panelRegValue.Controls.Add(this.labelRegValue_16);
            this.panelRegValue.Controls.Add(this.label21);
            this.panelRegValue.Controls.Add(this.labelRegValue_10);
            this.panelRegValue.Controls.Add(this.labelRegAddress);
            this.panelRegValue.Controls.Add(this.label23);
            this.panelRegValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRegValue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelRegValue.Location = new System.Drawing.Point(0, 0);
            this.panelRegValue.Name = "panelRegValue";
            this.panelRegValue.Size = new System.Drawing.Size(443, 27);
            this.panelRegValue.TabIndex = 18;
            // 
            // buttonSetRegValue
            // 
            this.buttonSetRegValue.Location = new System.Drawing.Point(289, -1);
            this.buttonSetRegValue.Name = "buttonSetRegValue";
            this.buttonSetRegValue.Size = new System.Drawing.Size(75, 21);
            this.buttonSetRegValue.TabIndex = 5;
            this.buttonSetRegValue.Text = "SetValue";
            this.buttonSetRegValue.UseVisualStyleBackColor = true;
            this.buttonSetRegValue.Click += new System.EventHandler(this.buttonSetRegValue_Click);
            // 
            // labelRegValue_16
            // 
            this.labelRegValue_16.Location = new System.Drawing.Point(236, 1);
            this.labelRegValue_16.Name = "labelRegValue_16";
            this.labelRegValue_16.Size = new System.Drawing.Size(56, 14);
            this.labelRegValue_16.TabIndex = 4;
            this.labelRegValue_16.Text = "0x5548";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(126, 1);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 14);
            this.label21.TabIndex = 3;
            this.label21.Text = "Value:";
            // 
            // labelRegValue_10
            // 
            this.labelRegValue_10.Location = new System.Drawing.Point(174, 1);
            this.labelRegValue_10.Name = "labelRegValue_10";
            this.labelRegValue_10.Size = new System.Drawing.Size(56, 14);
            this.labelRegValue_10.TabIndex = 2;
            this.labelRegValue_10.Text = "65535";
            // 
            // labelRegAddress
            // 
            this.labelRegAddress.Location = new System.Drawing.Point(64, 1);
            this.labelRegAddress.Name = "labelRegAddress";
            this.labelRegAddress.Size = new System.Drawing.Size(56, 14);
            this.labelRegAddress.TabIndex = 1;
            this.labelRegAddress.Text = "0x0001";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 1);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 14);
            this.label23.TabIndex = 0;
            this.label23.Text = "Address:";
            // 
            // FADP1701VX
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(443, 524);
            this.Controls.Add(this.splitContainerReg);
            this.Name = "FADP1701VX";
            this.Text = "FADP1701VX";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainerReg.Panel1.ResumeLayout(false);
            this.splitContainerReg.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerReg)).EndInit();
            this.splitContainerReg.ResumeLayout(false);
            this.panelRegValue.ResumeLayout(false);
            this.panelRegValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer fDeamon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linkLabelPLCAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label labelADCAResultCount;
        private System.Windows.Forms.ListView listViewRegValue;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelErrorCode;
        private System.Windows.Forms.Label labelA27;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labelA26;
        private System.Windows.Forms.Label labelA25;
        private System.Windows.Forms.Label labelA24;
        private System.Windows.Forms.Label labelA23;
        private System.Windows.Forms.Label labelA22;
        private System.Windows.Forms.Label labelA21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelAVRef;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labelModbusAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPLCSN;
        private System.Windows.Forms.SplitContainer splitContainerReg;
        private System.Windows.Forms.Label labelA17;
        private System.Windows.Forms.Label labelA16;
        private System.Windows.Forms.Label labelA15;
        private System.Windows.Forms.Label labelA14;
        private System.Windows.Forms.Label labelA13;
        private System.Windows.Forms.Label labelA12;
        private System.Windows.Forms.Label labelA11;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelADCBResultCount;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelBVRef;
        private System.Windows.Forms.Button buttonRTCFG;
        private System.Windows.Forms.Panel panelRegValue;
        private System.Windows.Forms.Button buttonSetRegValue;
        private System.Windows.Forms.Label labelRegValue_16;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelRegValue_10;
        private System.Windows.Forms.Label labelRegAddress;
        private System.Windows.Forms.Label label23;
    }
}