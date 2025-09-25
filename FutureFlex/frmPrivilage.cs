using Bunifu.UI.WinForms;
using FutureFlex.Models;
using FutureFlex.SQL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureFlex
{
    public partial class frmPrivilage : Form
    {
        public frmPrivilage(List<PermissionModel> permissionModels)
        {
            InitializeComponent();
            this.Size = new Size(879, 564);
            _permissionModels = permissionModels;
        }

        List<PermissionModel> _permissionModels;

        string emp_username = null; // ตัวแปรสำหรับเก็บ username เมื่อกด ลบ แก้ไข กำหนดสิทธิ์

        BunifuSnackbar sk = new BunifuSnackbar();  //Notify Control


        async Task SHOW_CENTER_SCREEN(Guna2GroupBox gb)
        {
            // คืนค่าปุ่ม
            ClearFromMenuAndDetail();
            int x = (this.Width - gb.Width) / 2;
            int y = (this.Height - gb.Height) / 2;
            gb.Location = new System.Drawing.Point(x, y);
            gnTran.ShowSync(gb);
            await Task.Delay(100);
        }

        void CheckPermission()
        {
            // Define permission
            btnAddAccount.Enabled = false;
            dgvEmployee.Columns["cl_del"].Visible = false;
            dgvEmployee.Columns["cl_edit"].Visible = false;
            dgvEmployee.Columns["cl_privilage"].Visible = false;
            if (EmployeeModel.emp_username == "sa")
            {
                btnAddAccount.Enabled = true;
                dgvEmployee.Columns["cl_del"].Visible = true;
                dgvEmployee.Columns["cl_edit"].Visible = true;
                dgvEmployee.Columns["cl_privilage"].Visible = true;
            }
            else
                foreach (PermissionModel item in _permissionModels)
                {
                    if (item.Menu == "Account")
                    {
                        if (item.Add)
                            btnAddAccount.Enabled = true;
                        if (item.Edit)
                            dgvEmployee.Columns["cl_edit"].Visible = true;
                        if (item.Delete)
                            dgvEmployee.Columns["cl_del"].Visible = true;
                    }
                    if (item.Menu == "Permission")
                    {
                        dgvEmployee.Columns["cl_privilage"].Visible = true;
                    }
                }
        }

        /// <summary>
        /// เครียข้อมูลเมนู
        /// </summary>
        void ClearFromMenuAndDetail()
        {
            // คืนค่า CheckBox
            foreach (Guna2CheckBox cb in gbPrivilage.Controls.OfType<Guna2CheckBox>())
            {
                cb.Checked = false;
            }
            // คืนค่า toggle switch
            foreach (BunifuToggleSwitch tgb in gbPrivilage.Controls.OfType<BunifuToggleSwitch>())
            {
                tgb.Checked = false;
            }
        }

        /// <summary>
        /// เครียข้อมูลช่องผู้ใช้งาน
        /// </summary>
        void ClearTextBoxUser()
        {
            foreach (Guna2TextBox txt in gbEmployee.Controls.OfType<Guna2TextBox>())
            {
                txt.Clear();
            }
        }



        private void frmPrivilage_Load(object sender, EventArgs e)
        {
            // เช็คสิทธิ์การใช้งานโปรแกรม
            CheckPermission();

            dgvEmployee.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Athiti", 12, System.Drawing.FontStyle.Regular);
            dgvEmployee.DefaultCellStyle.Font = new System.Drawing.Font("Athiti", 12, System.Drawing.FontStyle.Regular);
            dgvEmployee.DefaultCellStyle.ForeColor = Color.Black;
            dgvEmployee.RowTemplate.Height = 30;
            cbbType.SelectedIndex = 0;

            dgvEmployee.DataSource = tbEmployeeSQL.SELECTDATA();
        }

        private async void btnAddAccount_Click(object sender, EventArgs e)
        {
            pnDetail.Visible = false;
            await SHOW_CENTER_SCREEN(gbEmployee);
        }

        private void BTN_CLOSE(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            switch (btn.Tag)
            {

                case "employee":
                    foreach (var txt in gbEmployee.Controls.OfType<Guna2TextBox>())
                    {
                        txt.Clear();
                    }
                    emp_username = null;
                    gbEmployee.Visible = false;
                    pnDetail.Visible = true;
                    break;
                case "privilage":

                    foreach (var cb in gbPrivilage.Controls.OfType<Guna2CheckBox>())
                    {
                        cb.Checked = false;
                    }

                    foreach (var tgs in gbPrivilage.Controls.OfType<BunifuToggleSwitch>())
                    {
                        tgs.Checked = false;
                    }
                    gbPrivilage.Visible = false;
                    pnDetail.Visible = true;
                    break;
            }
        }

        private void BTN_SAVE(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;

            switch (btn.Tag)
            {
                case "employee":
                    // เช็คค่าว่างก่อนการบันทึก
                    foreach (Guna2TextBox txt in gbEmployee.Controls.OfType<Guna2TextBox>())
                    {
                        if (txt.Text == "")
                        {
                            sk.Show(this, "กรุณากรอกข้อมูลให้ครบก่อนการบันทึก", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                    }

                    // เช็คว่ารหัสตรงกันไหม
                    if (txtPassword.Text != txtCMPassword.Text)
                    {
                        sk.Show(this, "รหัสผ่าน ไม่ตรงกัน โปรดตรวจสอบ", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        return;
                    }

                    // เช็คว่าเป็น INSERT OR UPDATE
                    if (emp_username == null) // INSERT
                    {
                        // บันทึก
                        if (tbEmployeeSQL.INSERTDATA(txtFullname.Text, txtUsername.Text, txtCMPassword.Text))
                        {
                            // เครียค่า
                            foreach (Guna2TextBox txt in gbEmployee.Controls.OfType<Guna2TextBox>())
                            {
                                txt.Clear();
                            }

                            gbEmployee.Visible = false;
                            pnDetail.Visible = true;
                            dgvEmployee.DataSource = tbEmployeeSQL.SELECTDATA();

                            sk.Show(this, "เพิ่มข้อมูลผู้ใช้สำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        }
                        else
                        {
                            sk.Show(this, tbEmployeeSQL.ERR, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        }
                    }
                    else // UPDATE
                    {
                        if (tbEmployeeSQL.UPDATE(txtFullname.Text, txtUsername.Text, txtCMPassword.Text, emp_username))
                        {
                            gbEmployee.Visible = false;
                            pnDetail.Visible = true;
                            dgvEmployee.DataSource = tbEmployeeSQL.SELECTDATA();

                            sk.Show(this, "แก้ไขข้อมูลผู้ใช้ สำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            emp_username = null;
                        }
                        else
                        {
                            sk.Show(this, tbEmployeeSQL.ERR, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                        }
                    }

                    ClearTextBoxUser();
                    break;
                case "privilage":
                    
                    if (tbPrivilage.DELETE(emp_username))
                    {
                        if (cbWeightPO.Checked)
                        {
                            tbPrivilage.INSERT(emp_username, cbWeightPO.Tag.ToString(), tgsPO_add.Checked.ToString(), tgsPO_del.Checked.ToString(), tgsPO_edit.Checked.ToString());
                        }
                        if (cbWeightJIT.Checked)
                        {
                            tbPrivilage.INSERT(emp_username, cbWeightJIT.Tag.ToString(), tgsJIT_add.Checked.ToString(), tgsJIT_del.Checked.ToString(), tgsJIT_edit.Checked.ToString());
                        }

                        if (cbWeightRTFG.Checked)
                        {
                            tbPrivilage.INSERT(emp_username, cbWeightRTFG.Tag.ToString(), tgsRTFG_add.Checked.ToString(), tgsRTFG_del.Checked.ToString(), tgsRTFG_edit.Checked.ToString());
                        }
                        if (cbWeightSPLIT.Checked)
                        {
                            tbPrivilage.INSERT(emp_username, cbWeightSPLIT.Tag.ToString(), tgsSPL_add.Checked.ToString(), tgsSPL_del.Checked.ToString(), tgsSPL_edit.Checked.ToString());
                        }

                        if (cbSetting.Checked)
                        {
                            tbPrivilage.INSERT(emp_username, cbSetting.Tag.ToString(), "False", "False", "False");
                        }

                        if (cbHistory.Checked)
                        {
                            tbPrivilage.INSERT(emp_username, cbHistory.Tag.ToString(), "False", "False", "False");
                        }

                        // เปิดสิทธิ์หน้าชั่ง
                        if (cbReprintJIT.Checked)
                        {
                            tbPrivilage.INSERT(emp_username, cbReprintJIT.Tag.ToString(), "False", "False", "False");
                        }

                        if (cbPermission.Checked)
                        {
                            tbPrivilage.INSERT(emp_username, cbPermission.Tag.ToString(), "False", "False", "False");
                        }

                        if (cbAccount.Checked)
                        {
                            tbPrivilage.INSERT(emp_username, cbAccount.Tag.ToString(), tgsACC_add.Checked.ToString(), tgsACC_edit.Checked.ToString(), tgsACC_del.Checked.ToString()) ;
                        }
                    }

                    gbPrivilage.Visible = false;
                    pnDetail.Visible = true;
                    emp_username = null;
                    ClearFromMenuAndDetail();

                    sk.Show(this, "กำหนดสิทธิ์การใช้งานสำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                    break;
            }
        }

        private async void dgvEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string columnName = dgvEmployee.Columns[e.ColumnIndex].Name.ToString();
                string fullName = dgvEmployee.Rows[e.RowIndex].Cells["cl_emp_name"].Value.ToString();
                string username = dgvEmployee.Rows[e.RowIndex].Cells["cl_emp_username"].Value.ToString();
                string password = dgvEmployee.Rows[e.RowIndex].Cells["cl_emp_password"].Value.ToString();

                switch (columnName)
                {
                    case "cl_del":
                        if (username == "sa")
                        {
                            sk.Show(this, "ไม่สามารถ ลบ, แก้ไข หรือ กำหนสิทธื์การใช้งาน กับสิทธิ์สุงสุดของระบบได้ได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }

                        DialogResult dialog = MessageBox.Show($"คุณต้องการลบผู้ใช้ {fullName} ออกจากระบบหรือไม่", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialog == DialogResult.Yes)
                        {
                            // ลบสิทธ์ผู้ใช้งานระบบก่อน
                            if (tbPrivilage.DELETE(username))
                            {
                                if (tbEmployeeSQL.DELETE(username))
                                {
                                    sk.Show(this, $"ลบผู้ใช้ {fullName} ออกจากระบบสำเร็จ", BunifuSnackbar.MessageTypes.Success, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                                    dgvEmployee.DataSource = tbEmployeeSQL.SELECTDATA();
                                }
                                else
                                {
                                    sk.Show(this, tbEmployeeSQL.ERR, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                                    return;
                                }
                            }
                            else
                            {
                                sk.Show(this, tbEmployeeSQL.ERR, BunifuSnackbar.MessageTypes.Error, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                                return;
                            }
                        }
                        break;
                    case "cl_edit":
                        if (username == "sa")
                        {
                            sk.Show(this, "ไม่สามารถ ลบ, แก้ไข หรือ กำหนสิทธื์การใช้งาน กับสิทธิ์สุงสุดของระบบได้ได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                        emp_username = username;
                        pnDetail.Visible = false;

                        txtFullname.Text = fullName;
                        txtUsername.Text = username;
                        txtPassword.Text = password;

                        await SHOW_CENTER_SCREEN(gbEmployee);
                        break;
                    case "cl_privilage":
                        if (username == "sa")
                        {
                            sk.Show(this, "ไม่สามารถ ลบ, แก้ไข หรือ กำหนสิทธื์การใช้งาน กับสิทธิ์สุงสุดของระบบได้ได้", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                            return;
                        }
                        emp_username = username;
                        pnDetail.Visible = false;
                        // แสดงหน้าต่าง
                        await SHOW_CENTER_SCREEN(gbPrivilage);


                        // เช็คว่ามีสิทธิ์ในระบบหรือไม่
                        Permission permission = new Permission();
                        List<PermissionModel> list = permission.GetPermissionByEmployeeId(username);
                        for (int i = 0; i < list.Count; i++)
                        {
                            string menuname = list[i].Menu;
                            switch (menuname)
                            {
                                case "WeightPO":
                                    cbWeightPO.Checked = true;
                                    if (list[i].Add)
                                        tgsPO_add.Checked = true;
                                    if (list[i].Edit)
                                        tgsPO_edit.Checked = true;
                                    if (list[i].Delete)
                                        tgsPO_del.Checked = true;
                                    break;
                                case "WeightJIT":
                                    cbWeightJIT.Checked = true;
                                    if (list[i].Add)
                                        tgsJIT_add.Checked = true;
                                    if (list[i].Edit)
                                        tgsJIT_edit.Checked = true;
                                    if (list[i].Delete)
                                        tgsJIT_del.Checked = true;
                                    break;
                                case "WeightRTFG":
                                    cbWeightRTFG.Checked = true;
                                    if (list[i].Add)
                                        tgsRTFG_add.Checked = true;
                                    if (list[i].Edit)
                                        tgsRTFG_edit.Checked = true;
                                    if (list[i].Delete)
                                        tgsRTFG_del.Checked = true;
                                    break;
                                case "WeightSPL":
                                    cbWeightSPLIT.Checked = true;
                                    if (list[i].Add)
                                        tgsSPL_add.Checked = true;
                                    if (list[i].Edit)
                                        tgsSPL_edit.Checked = true;
                                    if (list[i].Delete)
                                        tgsSPL_del.Checked = true;
                                    break;
                                case "History":
                                    cbHistory.Checked = true;
                                    break;
                                case "Setting":
                                    cbSetting.Checked = true;
                                    break;
                                case "Permission":
                                    cbPermission.Checked = true;
                                    break;
                                case "Account":
                                    cbAccount.Checked = true;
                                    if (list[i].Add)
                                        tgsACC_add.Checked = true;
                                    if (list[i].Edit)
                                        tgsACC_edit.Checked = true;
                                    if (list[i].Delete)
                                        tgsACC_del.Checked = true;
                                    break;
                                case "ReprintJIT":
                                    cbReprintJIT.Checked = true;
                                    break;
                            }
                        }
                        break;
                }


            }
            catch (Exception)
            {

            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '\0';

                txtCMPassword.UseSystemPasswordChar = false;
                txtCMPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '*';

                txtCMPassword.UseSystemPasswordChar = true;
                txtCMPassword.PasswordChar = '*';
            }
        }

        private void CHECKBOX_CHECKED(object sender, EventArgs e)
        {
            Guna2CheckBox cb = sender as Guna2CheckBox;

            switch (cb.Tag)
            {
                case "account":
                    if (cb.Checked == false)
                    {
                        tgsACC_add.Checked = false;
                        tgsACC_del.Checked = false;
                        tgsACC_edit.Checked = false;

                    }
                    else if (cb.Checked == true)
                    {
                        DataTable tb = tbPrivilage.CheckPrivilageMenu(emp_username, cb.Tag.ToString());
                        if (tb.Rows.Count != 0)
                        {
                            foreach (DataRow rw in tb.Rows)
                            {
                                string add = rw["pri_add"].ToString();
                                string edit = rw["pri_edit"].ToString();
                                string del = rw["pri_del"].ToString();

                                if (add == "True")
                                {
                                    tgsACC_add.Checked = true;
                                }

                                if (edit == "True")
                                {
                                    tgsACC_edit.Checked = true;
                                }

                                if (del == "True")
                                {
                                    tgsACC_del.Checked = true;
                                }
                            }
                        }

                    }
                    break;
                case "setting":
                    break;
                case "weight":
                    if (cb.Checked == false)
                    {
                        tgsJIT_del.Checked = false;
                        tgsJIT_edit.Checked = false;
                    }
                    else if (cb.Checked == true)
                    {
                        DataTable tb = tbPrivilage.CheckPrivilageMenu(emp_username, cb.Tag.ToString());
                        if (tb.Rows.Count != 0)
                        {
                            foreach (DataRow rw in tb.Rows)
                            {
                                string edit = rw["pri_edit"].ToString();
                                string del = rw["pri_del"].ToString();

                                if (edit == "True")
                                {
                                    tgsJIT_del.Checked = true;
                                }

                                if (del == "True")
                                {
                                    tgsJIT_edit.Checked = true;
                                }
                            }
                        }
                    }
                    break;
                case "reprintJIT":
                    break;
                case "history":
                    break;
            }
        }

        private void TOGLE_CHECK(object sender, BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            BunifuToggleSwitch tgs = sender as BunifuToggleSwitch;
            if (tgs.Checked)
            {
                switch (tgs.Tag)
                {
                    case "weight":
                        cbReprintJIT.Checked = true;
                        break;
                    case "account":
                        cbWeightRTFG.Checked = true;
                        break;
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Text != "")
                {
                    string columnName = null;
                    switch (cbbType.SelectedIndex)
                    {
                        case 0:
                            columnName = "emp_username";
                            break;
                        case 1:
                            columnName = "emp_name";
                            break;
                    }

                    dgvEmployee.DataSource = tbEmployeeSQL.SEARCH_DATA(columnName, txtSearch.Text);
                }
                else
                {
                    sk.Show(this, "กรุณากรอกข้อมูลเพื่อทำการค้นหา", BunifuSnackbar.MessageTypes.Warning, 3000, "OK", BunifuSnackbar.Positions.TopCenter);
                }
            }
        }

        private void txtSearch_IconLeftClick(object sender, EventArgs e)
        {
            dgvEmployee.DataSource = tbEmployeeSQL.SELECTDATA();
        }

        private void gbPrivilage_Click(object sender, EventArgs e)
        {

        }
    }
}
