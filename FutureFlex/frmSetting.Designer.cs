
namespace FutureFlex
{
    partial class frmSetting
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
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cbbWGHC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbWGHB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIp = new Guna.UI2.WinForms.Guna2TextBox();
            this.msg = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.gbScale = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbDocnumber = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocNumPO = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDocNumJIT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDocNumOdoo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDocNumHistory = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbScale.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDocnumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(6, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(97, 25);
            this.label14.TabIndex = 15;
            this.label14.Text = "BAUTRATE : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(6, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 25);
            this.label15.TabIndex = 12;
            this.label15.Text = "COM : ";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(549, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 23;
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderRadius = 2;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor2 = System.Drawing.Color.MidnightBlue;
            this.btnSave.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnSave.HoverState.FillColor = System.Drawing.Color.MidnightBlue;
            this.btnSave.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSave.Location = new System.Drawing.Point(412, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(164, 35);
            this.btnSave.TabIndex = 77;
            this.btnSave.Text = "บันทึก";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbbWGHC
            // 
            this.cbbWGHC.BackColor = System.Drawing.Color.Transparent;
            this.cbbWGHC.BorderColor = System.Drawing.Color.MidnightBlue;
            this.cbbWGHC.BorderRadius = 1;
            this.cbbWGHC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbWGHC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWGHC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbWGHC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbWGHC.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbWGHC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbWGHC.ItemHeight = 30;
            this.cbbWGHC.Location = new System.Drawing.Point(11, 53);
            this.cbbWGHC.Name = "cbbWGHC";
            this.cbbWGHC.Size = new System.Drawing.Size(202, 36);
            this.cbbWGHC.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbWGHC.TabIndex = 78;
            this.cbbWGHC.Tag = "COM";
            this.cbbWGHC.DropDown += new System.EventHandler(this.GET_SERIALPORT);
            this.cbbWGHC.DropDownClosed += new System.EventHandler(this.CLEAR_COMBOBOX);
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
            this.label9.Location = new System.Drawing.Point(5, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "ตั้งค่าการเชื่อมต่อกับเครื่องชั่ง";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Athiti Medium", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(5, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 51);
            this.label10.TabIndex = 79;
            this.label10.Text = "Setting";
            // 
            // cbbWGHB
            // 
            this.cbbWGHB.BackColor = System.Drawing.Color.Transparent;
            this.cbbWGHB.BorderColor = System.Drawing.Color.MidnightBlue;
            this.cbbWGHB.BorderRadius = 1;
            this.cbbWGHB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbWGHB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWGHB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbWGHB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbWGHB.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbWGHB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbWGHB.ItemHeight = 30;
            this.cbbWGHB.Location = new System.Drawing.Point(11, 116);
            this.cbbWGHB.Name = "cbbWGHB";
            this.cbbWGHB.Size = new System.Drawing.Size(202, 36);
            this.cbbWGHB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbbWGHB.TabIndex = 81;
            this.cbbWGHB.Tag = "BUADRATE";
            this.cbbWGHB.DropDown += new System.EventHandler(this.GET_BUADRATE);
            this.cbbWGHB.DropDownClosed += new System.EventHandler(this.CLEAR_COMBOBOX);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "IP server :";
            // 
            // txtIp
            // 
            this.txtIp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIp.DefaultText = "";
            this.txtIp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIp.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIp.ForeColor = System.Drawing.Color.Black;
            this.txtIp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIp.Location = new System.Drawing.Point(6, 59);
            this.txtIp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtIp.Name = "txtIp";
            this.txtIp.PasswordChar = '\0';
            this.txtIp.PlaceholderText = "";
            this.txtIp.SelectedText = "";
            this.txtIp.Size = new System.Drawing.Size(213, 31);
            this.txtIp.TabIndex = 84;
            this.txtIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msg
            // 
            this.msg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msg.Caption = null;
            this.msg.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msg.Parent = this;
            this.msg.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msg.Text = null;
            // 
            // gbScale
            // 
            this.gbScale.Controls.Add(this.label15);
            this.gbScale.Controls.Add(this.label14);
            this.gbScale.Controls.Add(this.cbbWGHC);
            this.gbScale.Controls.Add(this.cbbWGHB);
            this.gbScale.Location = new System.Drawing.Point(10, 84);
            this.gbScale.Name = "gbScale";
            this.gbScale.Size = new System.Drawing.Size(225, 204);
            this.gbScale.TabIndex = 85;
            this.gbScale.TabStop = false;
            this.gbScale.Text = "การเชื่อมต่อเครื่องชั่ง";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtIp);
            this.groupBox2.Location = new System.Drawing.Point(10, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 147);
            this.groupBox2.TabIndex = 86;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TCP/IP";
            // 
            // gbDocnumber
            // 
            this.gbDocnumber.Controls.Add(this.txtDocNumHistory);
            this.gbDocnumber.Controls.Add(this.txtDocNumOdoo);
            this.gbDocnumber.Controls.Add(this.txtDocNumJIT);
            this.gbDocnumber.Controls.Add(this.txtDocNumPO);
            this.gbDocnumber.Controls.Add(this.label5);
            this.gbDocnumber.Controls.Add(this.label4);
            this.gbDocnumber.Controls.Add(this.label3);
            this.gbDocnumber.Controls.Add(this.label1);
            this.gbDocnumber.Location = new System.Drawing.Point(241, 84);
            this.gbDocnumber.Name = "gbDocnumber";
            this.gbDocnumber.Size = new System.Drawing.Size(341, 357);
            this.gbDocnumber.TabIndex = 86;
            this.gbDocnumber.TabStop = false;
            this.gbDocnumber.Text = "เลขที่เอกสาร";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "เลขที่เอกสารสติ๊กเกอร์ใบใหญ่(PO)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "เลขที่เอกสารสติ๊กเกอร์ใบใหญ่(JIT)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "เลขที่เอกสาร รายงานการส่งข้อมูลหา odoo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "เอกสารการชั่ง (ประวัติ)";
            // 
            // txtDocNumPO
            // 
            this.txtDocNumPO.Animated = true;
            this.txtDocNumPO.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocNumPO.DefaultText = "";
            this.txtDocNumPO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDocNumPO.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDocNumPO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocNumPO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocNumPO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocNumPO.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocNumPO.ForeColor = System.Drawing.Color.Black;
            this.txtDocNumPO.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocNumPO.Location = new System.Drawing.Point(11, 59);
            this.txtDocNumPO.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDocNumPO.Name = "txtDocNumPO";
            this.txtDocNumPO.PasswordChar = '\0';
            this.txtDocNumPO.PlaceholderText = "";
            this.txtDocNumPO.SelectedText = "";
            this.txtDocNumPO.Size = new System.Drawing.Size(324, 31);
            this.txtDocNumPO.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDocNumPO.TabIndex = 85;
            // 
            // txtDocNumJIT
            // 
            this.txtDocNumJIT.Animated = true;
            this.txtDocNumJIT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocNumJIT.DefaultText = "";
            this.txtDocNumJIT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDocNumJIT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDocNumJIT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocNumJIT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocNumJIT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocNumJIT.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocNumJIT.ForeColor = System.Drawing.Color.Black;
            this.txtDocNumJIT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocNumJIT.Location = new System.Drawing.Point(11, 134);
            this.txtDocNumJIT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDocNumJIT.Name = "txtDocNumJIT";
            this.txtDocNumJIT.PasswordChar = '\0';
            this.txtDocNumJIT.PlaceholderText = "";
            this.txtDocNumJIT.SelectedText = "";
            this.txtDocNumJIT.Size = new System.Drawing.Size(324, 31);
            this.txtDocNumJIT.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDocNumJIT.TabIndex = 86;
            // 
            // txtDocNumOdoo
            // 
            this.txtDocNumOdoo.Animated = true;
            this.txtDocNumOdoo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocNumOdoo.DefaultText = "";
            this.txtDocNumOdoo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDocNumOdoo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDocNumOdoo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocNumOdoo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocNumOdoo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocNumOdoo.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocNumOdoo.ForeColor = System.Drawing.Color.Black;
            this.txtDocNumOdoo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocNumOdoo.Location = new System.Drawing.Point(11, 222);
            this.txtDocNumOdoo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDocNumOdoo.Name = "txtDocNumOdoo";
            this.txtDocNumOdoo.PasswordChar = '\0';
            this.txtDocNumOdoo.PlaceholderText = "";
            this.txtDocNumOdoo.SelectedText = "";
            this.txtDocNumOdoo.Size = new System.Drawing.Size(324, 31);
            this.txtDocNumOdoo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDocNumOdoo.TabIndex = 87;
            // 
            // txtDocNumHistory
            // 
            this.txtDocNumHistory.Animated = true;
            this.txtDocNumHistory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocNumHistory.DefaultText = "";
            this.txtDocNumHistory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDocNumHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDocNumHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocNumHistory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDocNumHistory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocNumHistory.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocNumHistory.ForeColor = System.Drawing.Color.Black;
            this.txtDocNumHistory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDocNumHistory.Location = new System.Drawing.Point(11, 305);
            this.txtDocNumHistory.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtDocNumHistory.Name = "txtDocNumHistory";
            this.txtDocNumHistory.PasswordChar = '\0';
            this.txtDocNumHistory.PlaceholderText = "";
            this.txtDocNumHistory.SelectedText = "";
            this.txtDocNumHistory.Size = new System.Drawing.Size(324, 31);
            this.txtDocNumHistory.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDocNumHistory.TabIndex = 88;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(596, 489);
            this.Controls.Add(this.gbDocnumber);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbScale);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.guna2ControlBox1);
            this.Font = new System.Drawing.Font("Athiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.gbScale.ResumeLayout(false);
            this.gbScale.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbDocnumber.ResumeLayout(false);
            this.gbDocnumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox cbbWGHC;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cbbWGHB;
        private Guna.UI2.WinForms.Guna2TextBox txtIp;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2MessageDialog msg;
        private System.Windows.Forms.GroupBox gbDocnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtDocNumHistory;
        private Guna.UI2.WinForms.Guna2TextBox txtDocNumOdoo;
        private Guna.UI2.WinForms.Guna2TextBox txtDocNumJIT;
        private Guna.UI2.WinForms.Guna2TextBox txtDocNumPO;
    }
}