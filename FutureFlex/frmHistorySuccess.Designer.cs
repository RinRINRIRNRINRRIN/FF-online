namespace FutureFlex
{
    partial class frmHistorySuccess
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorySuccess));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.cl_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_seq = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_numMeter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wdt_pch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_net = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_dateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_machineOperator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_wgh_employee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_lot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchGV = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpStop = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblStructure = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblJobType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblPO = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbPO = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnExport = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv.ColumnHeadersHeight = 45;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_status,
            this.cl_seq,
            this.cl_wgh_numMeter,
            this.wdt_pch,
            this.cl_wgh_net,
            this.cl_wgh_dateTime,
            this.cl_wgh_machineOperator,
            this.cl_wgh_employee,
            this.cl_lot});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.White;
            this.dgv.Location = new System.Drawing.Point(289, 102);
            this.dgv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Navy;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowTemplate.Height = 40;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(1418, 861);
            this.dgv.TabIndex = 1;
            // 
            // cl_status
            // 
            this.cl_status.HeaderText = "ODOO";
            this.cl_status.Name = "cl_status";
            this.cl_status.ReadOnly = true;
            this.cl_status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_seq
            // 
            this.cl_seq.DataPropertyName = "wdt_seq";
            this.cl_seq.HeaderText = "ลำดับ";
            this.cl_seq.Name = "cl_seq";
            this.cl_seq.ReadOnly = true;
            this.cl_seq.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wgh_numMeter
            // 
            this.cl_wgh_numMeter.DataPropertyName = "wdt_meter_kg_in_roll";
            this.cl_wgh_numMeter.HeaderText = "จำนวนม้วน/กล่อง";
            this.cl_wgh_numMeter.Name = "cl_wgh_numMeter";
            this.cl_wgh_numMeter.ReadOnly = true;
            this.cl_wgh_numMeter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_numMeter.Width = 180;
            // 
            // wdt_pch
            // 
            this.wdt_pch.DataPropertyName = "wdt_pch";
            this.wdt_pch.HeaderText = "จำนวนใบ";
            this.wdt_pch.Name = "wdt_pch";
            this.wdt_pch.ReadOnly = true;
            this.wdt_pch.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wgh_net
            // 
            this.cl_wgh_net.DataPropertyName = "wdt_net";
            this.cl_wgh_net.HeaderText = "น้ำหนัก";
            this.cl_wgh_net.Name = "cl_wgh_net";
            this.cl_wgh_net.ReadOnly = true;
            this.cl_wgh_net.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cl_wgh_dateTime
            // 
            this.cl_wgh_dateTime.DataPropertyName = "wdt_date";
            this.cl_wgh_dateTime.HeaderText = "วันที่ชั่ง";
            this.cl_wgh_dateTime.Name = "cl_wgh_dateTime";
            this.cl_wgh_dateTime.ReadOnly = true;
            this.cl_wgh_dateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_dateTime.Width = 170;
            // 
            // cl_wgh_machineOperator
            // 
            this.cl_wgh_machineOperator.DataPropertyName = "wdt_oparator";
            this.cl_wgh_machineOperator.HeaderText = "ผู้ควบคุมเครื่อง";
            this.cl_wgh_machineOperator.Name = "cl_wgh_machineOperator";
            this.cl_wgh_machineOperator.ReadOnly = true;
            this.cl_wgh_machineOperator.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_machineOperator.Width = 150;
            // 
            // cl_wgh_employee
            // 
            this.cl_wgh_employee.DataPropertyName = "wdt_employee";
            this.cl_wgh_employee.HeaderText = "พนักงานชั่ง";
            this.cl_wgh_employee.Name = "cl_wgh_employee";
            this.cl_wgh_employee.ReadOnly = true;
            this.cl_wgh_employee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_wgh_employee.Width = 130;
            // 
            // cl_lot
            // 
            this.cl_lot.DataPropertyName = "wdt_lot";
            this.cl_lot.HeaderText = "Lot No.";
            this.cl_lot.Name = "cl_lot";
            this.cl_lot.ReadOnly = true;
            this.cl_lot.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cl_lot.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "เลือก GV ที่ต้องการค้นหา";
            // 
            // txtSearchGV
            // 
            this.txtSearchGV.BorderColor = System.Drawing.Color.Black;
            this.txtSearchGV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchGV.DefaultText = "";
            this.txtSearchGV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchGV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchGV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchGV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchGV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchGV.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchGV.ForeColor = System.Drawing.Color.Black;
            this.txtSearchGV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchGV.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSearchGV.IconRight")));
            this.txtSearchGV.Location = new System.Drawing.Point(12, 352);
            this.txtSearchGV.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.txtSearchGV.Name = "txtSearchGV";
            this.txtSearchGV.PasswordChar = '\0';
            this.txtSearchGV.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSearchGV.PlaceholderText = "เลขที่ GV";
            this.txtSearchGV.SelectedText = "";
            this.txtSearchGV.Size = new System.Drawing.Size(268, 38);
            this.txtSearchGV.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchGV.TabIndex = 73;
            this.txtSearchGV.IconRightClick += new System.EventHandler(this.txtSearchGV_IconRightClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 71;
            this.label7.Text = "วันที่สิ้นสุด :";
            // 
            // dtpStop
            // 
            this.dtpStop.BorderRadius = 4;
            this.dtpStop.Checked = true;
            this.dtpStop.FillColor = System.Drawing.Color.MidnightBlue;
            this.dtpStop.Font = new System.Drawing.Font("Athiti", 12F);
            this.dtpStop.ForeColor = System.Drawing.Color.White;
            this.dtpStop.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStop.Location = new System.Drawing.Point(12, 190);
            this.dtpStop.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStop.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStop.Name = "dtpStop";
            this.dtpStop.Size = new System.Drawing.Size(268, 36);
            this.dtpStop.TabIndex = 70;
            this.dtpStop.Value = new System.DateTime(2024, 9, 18, 14, 27, 32, 211);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Athiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 69;
            this.label5.Text = "วันที่เริ่มค้น :";
            // 
            // dtpStart
            // 
            this.dtpStart.BorderRadius = 4;
            this.dtpStart.Checked = true;
            this.dtpStart.FillColor = System.Drawing.Color.MidnightBlue;
            this.dtpStart.Font = new System.Drawing.Font("Athiti", 12F);
            this.dtpStart.ForeColor = System.Drawing.Color.White;
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpStart.Location = new System.Drawing.Point(11, 126);
            this.dtpStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(268, 36);
            this.dtpStart.TabIndex = 68;
            this.dtpStart.Value = new System.DateTime(2024, 9, 18, 14, 27, 32, 211);
            // 
            // lblStructure
            // 
            this.lblStructure.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStructure.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStructure.ForeColor = System.Drawing.Color.Black;
            this.lblStructure.Location = new System.Drawing.Point(12, 572);
            this.lblStructure.Name = "lblStructure";
            this.lblStructure.Size = new System.Drawing.Size(267, 81);
            this.lblStructure.TabIndex = 67;
            this.lblStructure.Text = ".......";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(17, 542);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 25);
            this.label8.TabIndex = 66;
            this.label8.Text = "โครงสร้าง :";
            // 
            // lblJobType
            // 
            this.lblJobType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJobType.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJobType.ForeColor = System.Drawing.Color.Black;
            this.lblJobType.Location = new System.Drawing.Point(12, 787);
            this.lblJobType.Name = "lblJobType";
            this.lblJobType.Size = new System.Drawing.Size(268, 75);
            this.lblJobType.TabIndex = 65;
            this.lblJobType.Text = ".......";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 762);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 64;
            this.label6.Text = "ขนาดงาน :";
            // 
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCustomer.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblCustomer.Location = new System.Drawing.Point(12, 467);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(267, 75);
            this.lblCustomer.TabIndex = 61;
            this.lblCustomer.Text = ".......";
            // 
            // lblProduct
            // 
            this.lblProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProduct.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(12, 678);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(268, 76);
            this.lblProduct.TabIndex = 60;
            this.lblProduct.Text = ".......";
            // 
            // lblPO
            // 
            this.lblPO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPO.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPO.ForeColor = System.Drawing.Color.Black;
            this.lblPO.Location = new System.Drawing.Point(66, 406);
            this.lblPO.Name = "lblPO";
            this.lblPO.Size = new System.Drawing.Size(213, 25);
            this.lblPO.TabIndex = 59;
            this.lblPO.Text = ".......";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 653);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "ชื่อสินค้า :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 442);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "ชื่อลูกค้า :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Athiti Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "PO :";
            // 
            // cbbPO
            // 
            this.cbbPO.BackColor = System.Drawing.Color.Transparent;
            this.cbbPO.BorderColor = System.Drawing.Color.Navy;
            this.cbbPO.BorderRadius = 6;
            this.cbbPO.BorderThickness = 0;
            this.cbbPO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbPO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPO.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbPO.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPO.ForeColor = System.Drawing.Color.Black;
            this.cbbPO.ItemHeight = 30;
            this.cbbPO.Location = new System.Drawing.Point(13, 306);
            this.cbbPO.Name = "cbbPO";
            this.cbbPO.Size = new System.Drawing.Size(266, 36);
            this.cbbPO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbPO.TabIndex = 55;
            this.cbbPO.SelectedIndexChanged += new System.EventHandler(this.cbbPO_SelectedIndexChanged);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Navy;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1662, 6);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 12;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.Teal;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.Teal;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(7, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 25);
            this.label9.TabIndex = 26;
            this.label9.Text = "ค้นหาทุกรายการตามเงือนไขที่ต้องการ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Athiti Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(7, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(318, 51);
            this.label10.TabIndex = 25;
            this.label10.Text = "ค้นหาข้อมูล GV ทั้งหมด";
            // 
            // btnExport
            // 
            this.btnExport.Animated = true;
            this.btnExport.BorderRadius = 2;
            this.btnExport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExport.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.btnExport.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.btnExport.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnExport.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnExport.Location = new System.Drawing.Point(12, 915);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(270, 43);
            this.btnExport.TabIndex = 75;
            this.btnExport.Text = "Export";
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Animated = true;
            this.guna2GradientButton1.BorderRadius = 2;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.guna2GradientButton1.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GradientButton1.Location = new System.Drawing.Point(11, 233);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(268, 35);
            this.guna2GradientButton1.TabIndex = 76;
            this.guna2GradientButton1.Text = "ค้นหา";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // frmHistorySuccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1715, 970);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblStructure);
            this.Controls.Add(this.txtSearchGV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblJobType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.dtpStop);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.cbbPO);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPO);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmHistorySuccess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHistorySuccess";
            this.Load += new System.EventHandler(this.frmHistorySuccess_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbPO;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblPO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStructure;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblJobType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_seq;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_numMeter;
        private System.Windows.Forms.DataGridViewTextBoxColumn wdt_pch;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_net;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_dateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_machineOperator;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_wgh_employee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_lot;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStart;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpStop;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchGV;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2GradientButton btnExport;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}