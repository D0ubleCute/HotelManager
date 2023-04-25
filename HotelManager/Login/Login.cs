using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.Controller;
using HotelManager.DAO;
using HotelManager.Admin;
using HotelManager.NhanVien;
using HotelManager.Helper;

namespace HotelManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUserID;
            txtPassword_Leave(sender, e);
        }

        private void txtUserID_Enter(object sender, EventArgs e)
        {
            if (txtUserID.Text == "Địa chỉ Email...")
            {
                txtUserID.Text = "";
                txtUserID.ForeColor = Color.Black;
            }
        }

        private void txtUserID_Leave(object sender, EventArgs e)
        {
            if (txtUserID.Text == "")
            {
                txtUserID.Text = "Địa chỉ Email...";
                txtUserID.ForeColor = Color.FromArgb(170, 170, 170);
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Mật khẩu...")
            {
                txtPassword.Text = "";
                txtPassword.PasswordChar = '*';
                txtPassword.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Mật khẩu...";
                txtPassword.PasswordChar = '\0';
                txtPassword.ForeColor = Color.FromArgb(170, 170, 170);
            }
        }
     
        //private void llbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    QuenMatKhau frm = new QuenMatKhau();
        //    this.Hide();
        //    frm.Show();
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserID.Text;
            string password = txtPassword.Text;

            bool result = AccountController.Login(username, password);

            Account test = AccountController.GetAccountByUsername(username);
            if (test == null)
            {
                MessageBox.Show("Tài khoản này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (result)
            {
                Account loginAccount = AccountController.GetAccountByUsername(username);
                if (loginAccount.type == 1) //admin
                {
                    QuanLy frm = new QuanLy(loginAccount.userName);
                    AccountController.ResetAttempsOrUnlockAccount(username);
                    MessageBox.Show("Đăng nhập thành công. Chào mừng Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frm.ShowDialog();
                    this.Show();
                }
                else if (loginAccount.type == 2 && loginAccount.isLocked == false) //staff
                {
                    NV frm = new NV(loginAccount.userName);
                    AccountController.ResetAttempsOrUnlockAccount(username);
                    MessageBox.Show("Đăng nhập thành công. Chào mừng " + loginAccount.displayName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frm.ShowDialog();
                    Show();
                }
                else if (loginAccount.isLocked == true)
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khoá, liên hệ quản lý để biết thêm chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Tài khoản này không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            
            } else {
                bool getLocked = AccountController.DecreaseAttempsOrLockAccount(username);
                Account loginAccount = AccountController.GetAccountByUsername(username);

                if (getLocked && loginAccount.isLocked == false)
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu, bạn còn " + loginAccount.attempts + " lần thử", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                else if (getLocked && loginAccount.isLocked == true)
                {
                    MessageBox.Show("Tài khoản của bạn đã bị khoá, liên hệ quản lý để biết thêm chi tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }

        private void txtUserID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void txtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                btnLogin.Focus();
            }

            if (e.KeyValue == (char)13)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        }

        private void llbForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //if (txtUserID.Text != "")
            //{
            //    Staff staff = StaffController.GetStaffByUserName(txtUserID.Text);
            //    if (staff != null)
            //    {
            //        string password = Support.GetRandomPassword();
            //        if (AccountController.F(txtEmail.Text, password))
            //        {
            //            Admin.SendMail loader = new Admin.SendMail(txtEmail.Text, password, true);
            //            loader.ShowDialog();
            //            MessageBox.Show(loader.Result, "Thông báo");
            //        }
            //        else
            //            MessageBox.Show("Không thực hiện được", "Thông báo");
            //    }
            //}
        }
    }
}
