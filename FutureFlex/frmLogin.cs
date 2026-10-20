using FutureFlex.Function;
using FutureFlex.Models;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using Serilog;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            Log.Logger = new LoggerConfiguration()
.WriteTo.File(Application.StartupPath + "\\Logs\\log-.txt", rollingInterval: RollingInterval.Day)
.WriteTo.Console(Serilog.Events.LogEventLevel.Debug)
.CreateLogger();

            //VersionModel model = new VersionModel();
            //label5.Text = $"Version {model.GetFullVersion()}";
        }

        private int countToBypassUpdate = 0;

        void Login()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                Log.Information("พบผู้ใช้ไม่กรอกข้อมูล username หรือ password ไม่ครบ");
                md.Icon = MessageDialogIcon.Warning;
                md.Buttons = MessageDialogButtons.OK;
                md.Show("Please fill the username or password before log on", "Log on");
                return;
            }



            if (tbEmployeeSQL.LOGIN(txtUsername.Text, txtPassword.Text))
            {
                Log.Information("เข้าสู่ระบบสำเร็จ");
                txtUsername.Clear();
                txtPassword.Clear();
                frmMain frm = new frmMain();
                frm.Show();
                this.Hide();
            }
            else
            {
                Log.Information("พบผู้ใช้ไม่กรอกข้อมูล username หรือ password ไม่ถูกต้อง");
                txtUsername.Clear();
                txtPassword.Clear();
                MessageBox.Show("ผู้ใช้ หรือ รหัสผ่านไม่ถูกต้อง", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
        }

        bool CheckVersion()
        {

            VersionSQL versionSQL = new VersionSQL();
            if (!versionSQL.CheckVersoin())
            {
                msg.Icon = MessageDialogIcon.Information;
                msg.Buttons = MessageDialogButtons.OK;
                msg.Show("Have new version please update", "New version update");

                return false;
            }
            return true;
        }

        /// <summary>
        /// สำหรับเช็คว่าโปรแกมมีเปิดซ้ำไหม
        /// </summary>
        /// <returns></returns>
        bool CHECK_PROGRAM()
        {
            try
            {
                Process[] a = Process.GetProcessesByName("FutureFlex");

                if (a.Length > 1)
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private async void frmLogin_Load(object sender, EventArgs e)
        {
            Log.Information("=================================================================  Open program");
            VersionModel model = new VersionModel();
            Log.Information("Version build : " + model.GetFullVersion());
            Log.Information("Build date : " + model.GetBuildDate());
            // เช็คโปรแกรมว่ามีเปิดซ้ำหรือไม่
            if (CHECK_PROGRAM())
            {
                int x = (panel1.Width - gbConnection.Width) / 2;
                int y = (panel1.Height - gbConnection.Height) / 2;
                gbConnection.Location = new System.Drawing.Point(x, y);
                gbConnection.Show();
                gbConnection.Visible = true;
                label1.Text = "Connect server...";
                // Connec tcp server
                await Task.Delay(2000);
                if (!await func_tcpClient.Connect())
                {
                    msg.Icon = MessageDialogIcon.Error;
                    msg.Buttons = MessageDialogButtons.OK;
                    msg.Show(func_tcpClient.ERR, "TCP Server Error");
                    gbConnection.Visible = false;
                    panel1.Enabled = false;
                    Application.Exit();
                    return;
                }

                // ทดสอบเชื่อมต่อฐานข้อมูล
                if (await server.ConnectDatabase())
                {
                    Log.Warning("เชื่อมต่อฐานข้อมูลสำเร็จ");
                    await Task.Delay(900);
                    label1.Text = "Connect success";
                   
                    gbConnection.Visible = false;
                    txtUsername.Focus();
                    tbOdoo.defineServerOdoo();
                }
                else
                {
                    Log.Warning("ไม่สามารถเชื่อมต่อฐานข้อมูลได้");
                    label1.Text = $"Connect fail";
                    label1.ForeColor = System.Drawing.Color.Red;
                    md.Icon = MessageDialogIcon.Error;
                    md.Buttons = MessageDialogButtons.OK;
                    md.Show($"Fails to connect database\nError : {server.ERR}", "Error Server");
                }
            }
            else
            {
                Log.Warning("พบโปรแกรมเปิดอยู่");
                MessageBox.Show("มีโปรแกรมเปิดอยู่แล้ว", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Log.Information("=================================================================  Program is closing");
                Application.Exit();
            }
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Login();
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';
            }
            else if (cbShowPassword.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Login();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F8)
            {
                countToBypassUpdate++;
            }
        }

        private void guna2CirclePictureBox1_DoubleClick(object sender, EventArgs e)
        {
            frmConnect frmConnect = new frmConnect();
            frmConnect.ShowDialog();
        }
    }
}
