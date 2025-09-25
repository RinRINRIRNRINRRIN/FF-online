using FutureFlex.Models;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using Serilog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;


namespace FutureFlex
{

    public partial class frmMain : Form
    {


        public frmMain()
        {
            InitializeComponent();

        }

        private List<PermissionModel> _model_list = new List<PermissionModel>();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;

            // แสดง permissoin
            if (EmployeeModel.emp_username == "sa")
            {
                foreach (var btn in this.Controls.OfType<Guna2Button>())
                {
                    btn.Enabled = true;
                }
            }
            else
            {
                // get permission menu
                Permission permission = new Permission();
                _model_list = permission.GetPermissionByEmployeeId(EmployeeModel.emp_username);
                if (_model_list != null)
                {
                    // loop check permission
                    for (int i = 0; i < _model_list.Count; i++)
                    {
                        // loop check button
                        foreach (var btn in this.Controls.OfType<Guna2Button>())
                        {
                            if (_model_list[i].Menu == btn.Tag.ToString())
                            {
                                btn.Enabled = true;
                            }
                        }
                    }
                }
            }

            // แสดงประเภทโปรแกรม
            string statusType = ConfigurationManager.AppSettings["DB_LOCAL"];
            string a = "";
            switch (statusType)
            {
                case "FutureflexUAT":
                    a = "UAT";
                    break;
                case "FutureFlex":
                    a = "Production";
                    break;
            }

            string status_odoo = ConfigurationManager.AppSettings["ODOO_STATUS"];
            switch (status_odoo)
            {
                case "UAT":
                    label4.Text = "ODOO : UAT";
                    break;
                case "PRO":
                    label4.Text = "ODOO : PRODUCTION";
                    break;
            }

            // นำชื่อผู้ใช้มาแสดงที่โปรแกรม
            label6.Text = EmployeeModel.emp_name;
            label5.Text = $"{server.serverLocal} : {a}";
            Log.Information($"server name : {label5.Text}");
            Log.Information($"employee name : {label6.Text}");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //=======================================   เมื่อมีการกดปิดโปรแกรมจะเข้ามาทำงานตรงนี้ 
        {
            Log.Information("=================================================================  Open Closing");
            Application.Exit();
        }

        private void MenuSelect(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;

            switch (btn.Tag)
            {
                case "WeightJIT":
                    frmWeightJIT frmJIT = new frmWeightJIT(_model_list);
                    frmJIT.ShowDialog();
                    break;
                case "WeightPO":
                    frmWeightPO frm = new frmWeightPO(_model_list);
                    frm.ShowDialog();
                    break;
                case "ReprintJIT":
                    frmReprintJIT frm1 = new frmReprintJIT();
                    frm1.ShowDialog();
                    break;
                case "History":
                    frmHistoryWeight frm2 = new frmHistoryWeight();
                    frm2.ShowDialog();
                    break;
                case "Account":
                    frmAccount frm3 = new frmAccount(_model_list);
                    frm3.ShowDialog();
                    break;
                case "Setting":
                    frmSetting frm4 = new frmSetting();
                    frm4.ShowDialog();
                    break;
                case "WeightRTFG":
                    frmRTFGList frmRTFGList = new frmRTFGList(_model_list);
                    frmRTFGList.ShowDialog();
                    break;
                case "WeightSPL":
                    frmSPLList frmSPLList = new frmSPLList(_model_list);
                    frmSPLList.ShowDialog();
                    break;
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                frmTcpClientServer frmTcpClientServer = new frmTcpClientServer();
                frmTcpClientServer.ShowDialog();
            }
            if (e.KeyCode == Keys.F9)
            {

                VersionModel versionModel = new VersionModel();
                md.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                md.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                md.Show("Version info\n" +
                    $"Program version : {versionModel.GetMajor()}.{versionModel.GetMinor()}.{versionModel.GetBuild()}\n" +
                    $"Program build version : {versionModel.GetFullVersion()}\n" +
                    $"Build Date : {versionModel.GetBuildDate()}", "Program information");
            }
        }
    }
}
