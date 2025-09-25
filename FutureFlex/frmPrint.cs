using DocumentFormat.OpenXml.Bibliography;
using FutureFlex.Models;
using FutureFlex.SQL;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;
using static FutureFlex.API.RTFG;

namespace FutureFlex
{
    public partial class frmPrint : Form
    {
        public frmPrint()
        {
            InitializeComponent();

            //int startwidth = (this.Width / 2) - 10;
            //rpvAlone.Width = startwidth;


        }

        public string PO { get; set; }
        /// <summary>
        /// สำหรับบอกว่าการพิมพ์รายงานก่อนส่งหา odoo นั้นเป็นรายงานแบไหน SPL,GV,RTFG เพื่อไปกำหนดค่าที่ RDLC
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// สำหรับกำหนดค่าให้กับ GV หากการพิมพ์ข้อมูลก่อนส่งหา odoo นั้นเป้นการพิมพ์แบบ Gv
        /// </summary>
        public string GV_name { get; set; }

        private int box = 0;
        private int roll = 0;

        string GvOrRTFGNumber = "";
        string productName = "";
        string customerName = "";
        string date = DateTime.Now.ToString("dd/MM/yyyy");
        string jobScale = "";
        double totalPch = 0;
        int totalList = 0;
        double totalNet = 0;

        private void frmPrint_Load(object sender, EventArgs e)
        {
            DefineHeader();
        }

        /// <summary>
        /// กำหนดหัวกระดาษ
        /// </summary>
        void DefineHeader()
        {
            DataTable tb = new DataTable();
            if (PO == "JIT")
            {
                tb = tbWeightDetail.SELECT_GVorRTFGor_SPL_formHistorySuccess(type, GV_name, "JIT");
            }
            else
            {
                tb = tbWeightDetail.SearchPoAndWeightType(PO, type);
            }



            // Get data tbweight
            foreach (DataRow rw in tb.Rows)
            {
                string _gvname = rw["wdt_gv_name"].ToString();
                string _rtfg = rw["wdt_rtfg_name"].ToString();
                string _spl_name = rw["wdt_spl_name"].ToString();
                if (_rtfg != "")
                {
                    GvOrRTFGNumber = _rtfg;
                }
                else if (_spl_name != "")
                {
                    GvOrRTFGNumber = _spl_name;
                }
                else
                {
                    GvOrRTFGNumber = _gvname;
                }
                // Get ดึงข้อมูลหลักของ tbweight
                DataTable tb1 = tbWeight.SELECT_SELECT_GV(_gvname);
                foreach (DataRow rw1 in tb1.Rows)
                {
                    productName = $"({rw1["wgh_productID"]} {rw1["wgh_product"]})";
                    customerName = rw1["wgh_customer"].ToString();
                    jobScale = rw1["wgh_typeSuccess"].ToString();
                    break;
                }
                break;
            }

            //// แยกม้วนกับกล่อง
            foreach (DataRow rw in tb.Rows)
            {
                switch (rw["wdt_type"].ToString())
                {
                    case "box":
                        box++;
                        break;
                    case "roll":
                        roll++;
                        break;
                }
            }

            // ตรวจสอบว่าควรจะแสดงรายการแบบ คู่หรือเดี่ยว
            if (box > 0 && roll > 0)  // กรณีแสดงคู่
            {
                // กำหนดขนาดของฟอร์ม คู่
                int startwidth = (this.Width / 2) - 10;
                rpvBox.Width = startwidth;
                rpvRoll.Location = new System.Drawing.Point(startwidth + 5, 72);
                rpvRoll.Width = startwidth;

                DefineReportBox(tb);
                DefineReportRoll(tb);
            }
            else // กรณีแสดงเดี่ยว
            {
                if (box > 0)
                {
                    rpvBox.Location = new System.Drawing.Point(12, 72);
                    rpvBox.Width = Width - 20;
                    rpvRoll.Visible = false;
                    DefineReportBox(tb);
                }
                else if (roll > 0)
                {
                    rpvRoll.Location = new System.Drawing.Point(12, 72);
                    rpvRoll.Width = Width - 20;
                    rpvBox.Visible = false;
                    DefineReportRoll(tb);
                }
            }


        }

        void DefineReportBox(DataTable tb)
        {
            DataSet1 dataSet1 = new DataSet1();

            // กำหนดค่าให้กับ datasource
            DefineDataTable("box", dataSet1, tb);

            // Set parameter
            DefineParameterReport(rpvBox);


            // ตั้งค่าตัว DataSource ของ ReportViewer
            RefreshReport(dataSet1, rpvBox);
        }

        void DefineReportRoll(DataTable tb)
        {
            DataSet1 dataSet1 = new DataSet1();

            // กำหนดค่าให้กับ datasource
            DefineDataTable("roll", dataSet1, tb);

            // Set parameter
            DefineParameterReport(rpvRoll);

            // ตั้งค่าตัว DataSource ของ ReportViewer
            RefreshReport(dataSet1, rpvRoll);
        }

        /// <summary>
        /// กำหนดข้อมูลไปใน Datatable
        /// </summary>
        /// <param name="type"></param>
        void DefineDataTable(string type, DataSet dataSet1, DataTable tb)
        {

            string _gvid = "";
            string _po = "";
            string _seq = "";
            string _net = "";
            string numPch = "";
            string _lot = "";
            string _employee = "";
            string meter = "";

            totalPch = 0;
            totalNet = 0;
            foreach (DataRow rw in tb.Rows)
            {
                if (rw["wdt_type"].ToString() == type)
                {
                    _gvid = rw["wdt_gv_name"].ToString();
                    _po = rw["wdt_po"].ToString();
                    _seq = rw["wdt_seqOrigin"].ToString();
                    _net = rw["wdt_net"].ToString();
                    meter = $"{double.Parse(rw["wdt_meter_kg_in_roll"].ToString()).ToString("#,###")} ม";
                    numPch = $"{double.Parse(rw["wdt_pch"].ToString()).ToString("#,###")} ใบ";
                    _lot = rw["wdt_lot"].ToString();
                    _employee = rw["wdt_employee"].ToString();

                    totalPch = totalPch + double.Parse(rw["wdt_pch"].ToString());
                    totalNet = totalNet + double.Parse(rw["wdt_net"].ToString());
                    switch (type)
                    {
                        case "box":
                            dataSet1.Tables["tbWeightDetail"].Rows.Add(_gvid, _po, _seq, _net, numPch, _lot, _employee);
                            break;
                        case "roll":
                            string meterAndPch = $"{meter}/{numPch}";
                            dataSet1.Tables["tbWeightDetail"].Rows.Add(_gvid, _po, _seq, _net, meterAndPch, _lot, _employee);
                            break;

                    }
                }
            }

            totalList = tb.Rows.Count;
        }

        /// <summary>
        /// Set parameter
        /// </summary>
        /// <param name="rpv"></param>
        void DefineParameterReport(ReportViewer rpv)
        {
            // Set parameter
            ReportParameter _productName = new ReportParameter("productName", productName);  // กำหนดค่า parameter 
            ReportParameter _customerName = new ReportParameter("customerName", customerName);  // กำหนดค่า parameter 
            ReportParameter _date = new ReportParameter("date", date);  // กำหนดค่า parameter 
            ReportParameter _jobScale = new ReportParameter("jobscale", jobScale);  // กำหนดค่า parameter 
            ReportParameter _totalList = new ReportParameter("totalList", totalList.ToString("#,###"));
            ReportParameter _totalPch = new ReportParameter("totalPch", totalPch.ToString("#,###"));  // กำหนดค่า parameter 
            ReportParameter _totalNet = new ReportParameter("totalNet", totalNet.ToString("#,###.00"));  // กำหนดค่า parameter 
            ReportParameter _GvOrRTFGNumber = new ReportParameter("rtpGvOrRTFGNumber", GvOrRTFGNumber);
            ReportParameter _GvOrRtfg = new ReportParameter("GvOrRTFG", type);
            // กำหนดเลขที่เอกสาร
            ConfigurationModel model = new ConfigurationModel();
            ReportParameter document = new ReportParameter("Docnumber", model.GetDocumentOdoo());
            rpv.LocalReport.SetParameters(new ReportParameter[] { _productName, _customerName, _date, _jobScale, _totalList, _totalPch, _totalNet, _GvOrRtfg, _GvOrRTFGNumber, document });
        }


        /// <summary>
        /// Refresh Report
        /// </summary>
        /// <param name="dataSet"></param>
        /// <param name="rpv"></param>
        void RefreshReport(DataSet dataSet, ReportViewer rpv)
        {
            // ตั้งค่าตัว DataSource ของ ReportViewer
            ReportDataSource rds = new ReportDataSource("DataSet1", dataSet.Tables["tbWeightDetail"]);
            DataTable tb = dataSet.Tables["tbWeightDetail"];
            rpv.LocalReport.DataSources.Clear();
            rpv.LocalReport.DataSources.Add(rds);
            rpv.SetDisplayMode(DisplayMode.PrintLayout);
            // รีเฟรช ReportViewer
            rpv.RefreshReport();
        }

        private void reportViewer1_PrintingBegin(object sender, ReportPrintEventArgs e)
        {
            Console.WriteLine("PrintBegin");
            this.Close();
        }

        private void reportViewer1_Print(object sender, ReportPrintEventArgs e)
        {

        }
    }
}
