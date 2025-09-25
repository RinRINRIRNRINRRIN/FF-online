using FutureFlex.API;
using FutureFlex.Function;
using FutureFlex.Models;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmSplit : Form
    {
        public frmSplit(List<PermissionModel> model)
        {
            InitializeComponent();

            int x = (this.Width - gbLoadData.Width) / 2;
            int y = (this.Height - gbLoadData.Height) / 2;

            gbLoadData.Location = new System.Drawing.Point(x, y);
            _permissionModel = model;
        }
        private List<PermissionModel> _permissionModel;

        public string weightType { get; set; }

        /// <summary>
        /// เก็บข้อมูลว่าเป็นงาน กล่องหรือม้วน
        /// </summary>
        private string statusType { get; set; }

        private string statusCounty { get; set; }   ///// ใช่้สำหรับเก็บค่า การเลือกประเทศ จาก Groupbox 
        private string statusSide { get; set; }    ///// ใช่้สำหรับเก็บค่า การเลือกด้าน จาก Groupbox 


        /// <summary>
        /// สำหรับเก็บค่าว่าพร้อมอ่าข้อมูลจาก server หรือไม่
        /// </summary>
        bool isRead { get; set; } = false;
        void SetPaperAndPrint()
        {
            // Set paper 
            if (cbPrint.Checked)
            {
                Log.Information("- ผู้ใช้เลือกพิมพ์ข้อมูล");

                // Check print is online?
                if (!func_print.SetPrinter(printDocument1, weightType))
                {

                    msg.Icon = MessageDialogIcon.Error;
                    msg.Buttons = MessageDialogButtons.OK;
                    msg.Show("Can't connect a printer", "Fails to connect printer");

                    return;
                }

                if (!radioButton4.Checked) // AutoPrint
                {
                    try
                    {
                        printDocument1.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        printPreviewDialog1.ShowDialog();
                    }
                    catch (Exception ex)
                    {

                        msg.Icon = MessageDialogIcon.Warning;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show("Please close the dialog before", "Close form print");

                        return;
                    }
                }
            }
        }

        void SendMessageToTcp()
        {
            Task.Run(async () =>
            {
                if (!await func_tcpClient.SendDataAsync("GET_DATA"))
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        msg.Icon = MessageDialogIcon.Error;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show($"Server Error connect \nError : {func_tcpClient.ERR}", "Server Port 5000 Error");
                    }));
                    Application.Exit();
                }
            });
        }

        /// <summary>
        /// สำหรับกำหนดค่า comport 
        /// </summary>
        bool DefineComport()
        {
            try
            {
                if (saScale.IsOpen)
                {
                    saScale.Close();
                }
                saScale.PortName = func_serialport.COM_SCALE;
                saScale.BaudRate = func_serialport.BAUDRATE_SCALE;
                saScale.Open();

                Log.Information($"== Serial port open");
                Log.Information($"-- COM SCALE : {saScale.PortName}");
                Log.Information($"-- COM BAUDRATE : {saScale.BaudRate}");
                Log.Information($"Scale is connected");
            }
            catch (Exception ex)
            {
                msg.Icon = MessageDialogIcon.Error;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show(ex.Message, "Error");
                return false;
            }

            return true;
        }

        void DefineParameterBeforeWeight()
        {
            // แสดงข้อมูลจาก Property
            lblName.Text = SLP.Name;
            lblDate.Text = MRP.mo_date;
            lblDateDelivery.Text = MRP.mo_date_delivery;
            lblMoFilm.Text = MRP.mo_film;
            lblMoBlock.Text = MRP.mo_block;
            lblMoWork.Text = MRP.mo_work;
            lblPartner.Text = MRP.partner_name;
            lblProduct.Text = MRP.product_name;
            lblProductUomName.Text = MRP.product_uom_name;
            lblMoType.Text = MRP.mo_type;
            lblRetrunQtyPch.Text = SLP.Return_qty_pch.ToString();
            lblReturnQtyWeight.Text = SLP.Return_qty_weight.ToString();
            label41.Text = MRP.mo_po_qty.ToString();
            //label21.Text = MRP.mo_station_name;
            label31.Text = MRP.product_roll_length + " เมตร";
            lblReturnQtyWeight.Text = SLP.Return_qty_weight.ToString() + " Kg";
        }


        /// <summary>
        /// สำหรับเปิดปิด textbox
        /// </summary>
        /// <param name="BoxOrRoll">roll or box</param>
        void EnableAndDisableData(string BoxOrRoll)
        {
            foreach (var txt in panel2.Controls.OfType<Guna.UI2.WinForms.Guna2TextBox>())
            {
                if (txt.Tag.ToString() == BoxOrRoll)
                {
                    txt.Text = "0";
                    txt.Enabled = true;
                }
                else
                {
                    txt.Enabled = false;
                }
            }
        }


        /// <summary>
        /// กำหนดค่าตัวแปลก่อนทำการปริ้น
        /// </summary>
        void DefinePrintParameter(string seq, string statusType, string net, string numBox, string numRoll, string numMeter, string pchBox, string pchRoll, string wghPaper, string wghCore, string opareter, string lot, string printType, string joint, string side)
        {

            // Print paper
            func_print._seq = seq;
            func_print._statusType = statusType;
            func_print._net = net;
            func_print._numBox = numBox;
            func_print._numRoll = numRoll;
            func_print._numMeter = numMeter;
            func_print._pchBox = pchBox;
            func_print._pchRoll = pchRoll;
            func_print._wghPaper = wghPaper;
            func_print._wghCore = wghCore;
            func_print.pictureBox1 = pictureBox1;
            func_print._operator = opareter;
            func_print._lot = lot;
            func_print.printType = printType;
            func_print.Side = side;
            MRP.mo_pono = SLP.new_po_customer;
            func_print._wghJoint = double.Parse(joint);
        }

        void CheckPermission()
        {
            // Define permission
            btnStart.Enabled = false;
            //dgvDetail.Columns["cl_del"].Visible = false;
            //dgvDetail.Columns["cl_edit"].Visible = false;
            if (EmployeeModel.emp_username == "sa")
            {
                btnStart.Enabled = true;
                //dgvDetail.Columns["cl_del"].Visible = true;
                //dgvDetail.Columns["cl_edit"].Visible = true;
            }
            else
                foreach (PermissionModel item in _permissionModel)
                {
                    if (item.Menu == "WeightSPL")
                    {
                        if (item.Add)
                            btnStart.Enabled = true;
                        //if (item.Edit)
                        //    dgvDetail.Columns["cl_del"].Visible = true;
                        //if (item.Delete)
                        //    dgvDetail.Columns["cl_edit"].Visible = true;
                    }
                }
        }


        private void KeyIn(object sender, KeyPressEventArgs e)
        {
            Guna2TextBox txt = sender as Guna2TextBox;

            // ตรวจสอบว่าตัวอักษรที่ผู้ใช้ป้อนเป็นตัวเลขหรือจุดทศนิยมหรือไม่
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                msg.Icon = MessageDialogIcon.Warning;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show("Please fill number only", "Numberic only");
                e.Handled = true; // ไม่อนุญาตให้ป้อนตัวอักษรนี้
            }

            // ถ้ามีจุดทศนิยมอยู่แล้ว และผู้ใช้ป้อนจุดทศนิยมอีก หรือ ถ้าจุดทศนิยมอยู่ที่ตำแหน่งแรก
            if ((e.KeyChar == '.') && ((sender as Guna.UI2.WinForms.Guna2TextBox).Text.IndexOf('.') > -1 || (sender as Guna.UI2.WinForms.Guna2TextBox).Text.Length == 0))
            {
                msg.Icon = MessageDialogIcon.Warning;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show("Please fill number only", "Numberic only");
                e.Handled = true;
            }
        }




        private async void frmSplit_Load(object sender, System.EventArgs e)
        {
            Log.Information($"==================================================   frmRTFGis open");
            pnMain.Visible = false;
            gbLoadData.Visible = true;
            switch (weightType)
            {
                case "PO":
                    lblWeightType.Text = $"ชั่งเพื่อขาย PO : {SLP.new_po_customer}";
                    break;
                default:
                    lblWeightType.Text = $"ชั่งเพื่อเก็บ : {weightType}";
                    break;
            }

            await Task.Delay(500);
            label1.Text = "กำลังกำหนดข้อมูลการชั่ง";
            // DefinPermission
            CheckPermission();

            // กำหนดข้อมูลการชั่ง
            DefineParameterBeforeWeight();

            await Task.Delay(500);
            label1.Text = "กำลังแสดงข้อมูล";


            gbLoadData.Visible = false;
            pnMain.Visible = true;
        }

        private void txtNumWant_TextChanged(object sender, System.EventArgs e)
        {
            if (txtNumWant.Text != "")
            {
                double a = 0;
                double b = 0;

                switch (statusType)
                {
                    case "box":
                        a = double.Parse(txtNumMetOrBoxPch.Text);
                        b = double.Parse(txtNumWant.Text);

                        double numPch = a - b;
                        txtSumPch.Text = numPch.ToString();
                        break;
                    case "roll":

                        a = double.Parse(txtNumMetOrBoxPch.Text);
                        b = double.Parse(txtNumWant.Text);

                        double NumMeter = a - b;
                        txtSumMeter.Text = NumMeter.ToString();

                        if (txtNunMeter.Text != "0")
                        {
                            double c = MRP.pch_length / 1000;
                            double d = NumMeter / c;
                            string[] f = d.ToString().Split('.');
                            txtSumPch.Text = f[0];
                        }

                        if (MRP.product_roll_length != 0)
                        {
                            double numMetPerRoll = MRP.product_roll_length;
                            double total = NumMeter / numMetPerRoll;
                            txtSumRollPerLot.Text = total.ToString("F2");
                        }
                        else
                        {
                            txtSumRollPerLot.Text = "0";
                        }
                        break;
                }
            }
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            // หากมีข้อมูลการชั่งที่ค้างยังไม่ส่งจะต้องชั่งต่อไม่ได้
            if (dgvDetail.Rows.Count == 1)
            {
                msg.Icon = MessageDialogIcon.Warning;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show("Can't start please send the data to odoo first", "Send the data to odoo");
                return;
            }

            if (statusCounty == null || statusSide == null || statusType == null)
            {
                msg.Icon = MessageDialogIcon.Warning;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show("Please check County , Side , Type before start", "Check the information");
                return;
            }


            switch (statusType)
            {
                case "box":
                    if (SLP.total_pch == 0)
                    {
                        msg.Icon = MessageDialogIcon.Warning;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show("Can't start because Pch num is 0 Pcs", "Pch num is 0");
                        return;
                    }
                    break;
                case "roll":
                    if (SLP.total_meter == 0)
                    {
                        msg.Icon = MessageDialogIcon.Warning;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show("Can't start because Pch num is 0 m.", "Pch meter is 0");
                        return;
                    }
                    break;
            }

            switch (btnStart.Text)
            {
                case "เริ่มชั่งสินค้า":
                    // กำหนดค่าให้กับ serialport
                    if (!DefineComport())
                    {
                        return;
                    }
                    btnStart.Text = "ยกเลิกชั่งสินค้า";
                    break;
                case "ยกเลิกชั่งสินค้า":
                    saScale.Close();
                    btnStart.Text = "เริ่มชั่งสินค้า";
                    break;
            }
        }

        private void saScale_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Console.WriteLine(saScale.ReadLine());
            if (btnStart.Text == "ยกเลิกชั่งสินค้า")  // จะรับข้เอมูลเมื่อมีการกดเริ่มชั่งสินค้าเท่าไรห่
            {
                // เช็คว่ามีข้อมูลที่ data grid แล้วหรือยัวง
                if (dgvDetail.Rows.Count == 1)
                {
                    return;
                }

                string net = "";
                string tare = "0.00";
                string gross = "0.00";

                string a = saScale.ReadLine();
                string[] b = a.Split('\r');
                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i].Contains("NET"))
                    {
                        Console.WriteLine(b[i]);
                        Console.WriteLine(b[i].Length);
                        string strSup = b[i].Substring(13, b[i].Length - 13).Trim();
                        double weight = double.Parse(strSup);
                        net = strSup;
                        break;
                    }
                }

                // สดงข้อมูลน้ำหนักที่อ่านมาได้
                BeginInvoke(new MethodInvoker(delegate ()
                {
                    lbTareWgh.Text = tare;
                    lbGrossWgh.Text = gross;
                }));

                // ตำนวนน้ำหนัก
                switch (statusType)
                {
                    case "box":
                        BeginInvoke(new MethodInvoker(delegate ()
                        {
                            lbNetWgh.Text = net;
                        }));
                        break;
                    case "roll":
                        double cors = Convert.ToDouble(txtWghCors.Text);
                        double _nett = double.Parse(net) - cors;
                        net = _nett.ToString();
                        BeginInvoke(new MethodInvoker(delegate ()
                        {
                            lbNetWgh.Text = net;
                        }));
                        Log.Information($"- น้ำหนักแกน - น้ำหนักสุทธิ์ {net}");
                        break;
                }

                // insert new data
                string _date = DateTime.Now.ToString("dd/MM/yy", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));
                string _Time = DateTime.Now.ToString("HH:mm:ss", System.Globalization.CultureInfo.CreateSpecificCulture("EN-en"));

                string _lot = $"{MRP.name}{_date.Replace("/", "").Trim()}{_Time.Replace(":", "").Trim()}";
                double _net = double.Parse(net);
                double _tare = double.Parse(tare);
                double _gross = double.Parse(gross);
                double _wgh_paper_plasic = 0;
                double _wgh_core = 0;
                int _wgh_joint = 0;
                int _numBox = 0;
                int _numRollAll = 0;
                double _numRoll = 0;
                double _wgh_meter_kg_in_rolll = 0;
                if (txtWghPaper.Text == "")
                {
                    _wgh_paper_plasic = 0;
                }
                else { _wgh_paper_plasic = double.Parse(txtWghPaper.Text); }
                if (txtWghCors.Text == "")
                {
                    _wgh_core = 0;
                }
                else { _wgh_core = double.Parse(txtWghCors.Text); }
                if (txtJoint.Text == "")
                {
                    _wgh_joint = 0;
                }
                else
                {
                    _wgh_joint = int.Parse(txtJoint.Text);
                }
                if (txtNumBox.Text == "")
                {
                    _numBox = 0;
                }
                else { _numBox = int.Parse(txtNumBox.Text); }
                if (txtNumRollAll.Text == "")
                {
                    _numRollAll = 0;
                }
                else { _numRollAll = int.Parse(txtNumRollAll.Text); }
                if (txtNumRoll.Text == "")
                {
                    _numRoll = 0;
                }
                else { _numRoll = double.Parse(txtNumRoll.Text); }
                int _pch = 0;
                switch (statusType)
                {
                    case "box":
                        _wgh_meter_kg_in_rolll = 0;
                        _pch = int.Parse(txtNumWant.Text);
                        break;
                    case "roll":
                        _wgh_meter_kg_in_rolll = double.Parse(txtNunMeter.Text);
                        _pch = int.Parse(txtPchRoll.Text);
                        break;
                }
                string printType = "";
                DataTable tb = new DataTable();
                switch (weightType)
                {
                    case "PO":
                        printType = "L";
                        tb = tbWeightDetail.INSERT_DATA(MRP.name, int.Parse(MRP.id), "", 0, SLP.Name, SLP.Id, SLP.new_po_customer, SLP.new_sale_name, statusCounty, statusType, statusSide, _net, _tare, _gross, _wgh_paper_plasic, _wgh_core, _wgh_joint, _wgh_meter_kg_in_rolll, _numBox, _numRollAll, _numRoll, _pch, _lot, txtOperator.Text, "SPL", printType);

                        break;
                    case "JIT":
                        printType = "S";
                        tb = tbWeightDetail.INSERT_DATA(MRP.name, int.Parse(MRP.id), "", 0, SLP.Name, SLP.Id, "", "", statusCounty, statusType, statusSide, _net, _tare, _gross, _wgh_paper_plasic, _wgh_core, _wgh_joint, _wgh_meter_kg_in_rolll, _numBox, _numRollAll, _numRoll, _pch, _lot, txtOperator.Text, "SPL", printType);
                        break;
                }

                // บันทึกข้อมูล
                if (tb.Rows.Count == 0)
                {
                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        msg.Icon = MessageDialogIcon.Error;
                        msg.Buttons = MessageDialogButtons.OK;
                        msg.Show($"Save weight error \nError : {tbWeightDetail.ERR}", "Save Error");
                    }));
                    return;
                }
                // loop อ่านค่าจาก datatable

                foreach (DataRow rw in tb.Rows)
                {
                    string Seq = rw["wdt_seqOrigin"].ToString();
                    string Lot = rw["wdt_lot"].ToString();
                    string Id = rw["id"].ToString();
                    string _joint = rw["wdt_wgh_joint"].ToString();
                    DefinePrintParameter(Seq, statusType, lbNetWgh.Text, txtNumBox.Text, txtNumRollAll.Text, txtNunMeter.Text, _pch.ToString(), txtPchRoll.Text, txtWghPaper.Text, txtWghCors.Text, txtOperator.Text, Lot, weightType, _joint, statusSide);

                    BeginInvoke(new MethodInvoker(delegate ()
                    {
                        dgvDetail.Rows.Add("", "", Id, Seq, Lot);
                    }));
                    break;

                }



                // Print Sticker
                _ = Task.Run(() =>
                {
                    SetPaperAndPrint();
                });

                return;
            }

        }

        private void dgvDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string cl_name = dgvDetail.Columns[e.ColumnIndex].Name;
            switch (cl_name)
            {
                case "cl_del":
                    msg.Icon = MessageDialogIcon.Question;
                    msg.Buttons = MessageDialogButtons.YesNo;
                    DialogResult dg = msg.Show($"Do you want delete \nLot New : {SLP.lot_name} ?", "Delete lot new");
                    if (dg == DialogResult.Yes)
                    {
                        if (tbWeightDetail.DELETE(dgvDetail.Rows[e.RowIndex].Cells["cl_weight_id"].Value.ToString()))
                        {
                            dgvDetail.Rows.RemoveAt(0);
                        }
                        else
                        {
                            msg.Buttons = MessageDialogButtons.OK;
                            msg.Icon = MessageDialogIcon.Error;
                            msg.Show($"Delete fails \nError : {tbWeightDetail.ERR}", "Delete error");
                            return;
                        }
                    }
                    break;
                case "cl_print":
                    int id = 0;
                    foreach (DataGridViewRow rw in dgvDetail.Rows)
                    {
                        // Print data 
                        id = int.Parse(rw.Cells["cl_weight_id"].Value.ToString());
                        func_print._seq = rw.Cells["cl_seq"].Value.ToString();
                        func_print._lot = rw.Cells["cl_newLot"].Value.ToString();
                        break;
                    }
                    func_print._statusType = SLP.select_type;
                    func_print._net = lbNetWgh.Text;
                    func_print._numBox = txtNumBox.Text;
                    func_print._numRoll = txtNumRollAll.Text;
                    func_print._numMeter = txtNumWant.Text;
                    func_print._pchBox = txtSumPch.Text;
                    func_print._pchRoll = txtSumPch.Text;
                    func_print._wghPaper = txtWghPaper.Text;
                    func_print._wghCore = txtWghCors.Text;
                    func_print.pictureBox1 = pictureBox1;
                    func_print._operator = txtOperator.Text;

                    // Print Sticker
                    _ = Task.Run(() =>
                    {
                        BeginInvoke(new MethodInvoker(delegate ()
                        {
                            SetPaperAndPrint();
                        }));
                    });
                    break;
            }
        }

        private void frmSplit_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRead = false;
            Thread.Sleep(1000);
            saScale.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            func_print.FormatPrint(e);
        }

        private void txtNunMeter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNunMeter.Text != "")
                {
                    if (txtNunMeter.Text != "0")
                    {
                        string a = MRP.pch_length.ToString();

                        if (MRP.shrink_mm != 0)
                        {
                            double aa = MRP.pch_length + MRP.shrink_mm;
                            a = aa.ToString();
                        }


                        double c = double.Parse(a) / 1000;
                        double d = double.Parse(txtNunMeter.Text) / c;

                        double total = Math.Truncate(d);
                        txtPchRoll.Text = total.ToString();
                    }

                    // ถ้าจะนวนความยาวม้วนเต็มทั้งหมด เป็น 0 ไม่ต้องคำนวนต่อ
                    if (MRP.product_roll_length != 0)
                    {
                        double numMetPerRoll = MRP.product_roll_length;
                        double numMet = double.Parse(txtNunMeter.Text);
                        double total = numMet / numMetPerRoll;
                        txtNumRoll.Text = total.ToString("F2");
                    }
                    txtNumWant.Text = txtNunMeter.Text;
                }
                else { txtNumWant.Text = "0"; }
            }
            catch (Exception)
            {


            }
        }

        private void rdTypeBox_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdbName = sender as RadioButton;
            switch (rdbName.Name)
            {
                case "rdTypeRoll":
                    statusType = "roll";
                    gbSide.Enabled = true;
                    txtNumBox.Enabled = false;
                    EnableAndDisableData("roll");
                    txtNumMetOrBoxPch.Text = SLP.total_meter.ToString();
                    label15.Text = "จำนวนแมตรตั้งต้น";
                    label8.Text = "จำนวนเมตรที่ต้องการใช้";
                    //txtNumRollAll.Enabled = false;
                    //txtNunMeter.Enabled = false;
                    break;
                case "rdTypeBox":
                    btnReprint.Text = "น้ำหนักสุทธิ - น้ำหนักแกน";
                    statusType = "box";
                    btnReprint.Text = "NET WEIGHT";
                    rdNot.Checked = true;
                    gbSide.Enabled = false;
                    EnableAndDisableData("box");
                    txtNumMetOrBoxPch.Text = SLP.total_pch.ToString();
                    label15.Text = "จำนวนใบตั้งต้น";
                    label8.Text = "จำนวนเมตรที่ต้องการใช้";
                    //txtNumBox.Enabled = false;
                    //txtPchBox.Enabled = false;
                    break;

            }
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gbType_Click(object sender, EventArgs e)
        {

        }

        private void SelectSide(object sender, EventArgs e)
        {

            RadioButton rdb = sender as RadioButton;
            if (rdb.Checked)
                statusSide = rdb.Tag.ToString();

        }

        private void SelectCountry(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if (rdb.Checked)
            {
                statusCounty = rdb.Tag.ToString();
            }
        }

        private void txtPchBox_TextChanged(object sender, EventArgs e)
        {
            if (txtPchBox.Text != "")
            {
                txtNumWant.Text = txtPchBox.Text;
            }
            else { txtNumWant.Text = "0"; }
        }
    }
}
