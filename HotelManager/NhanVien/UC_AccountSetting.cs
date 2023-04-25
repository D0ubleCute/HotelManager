using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.Controller;

namespace HotelManager.NhanVien
{
    public partial class UC_AccountSetting : UserControl
    {
        private string idStaff;
        public UC_AccountSetting(String idStaff)
        {
            InitializeComponent();

            this.idStaff = idStaff;
            Staff staff = StaffController.GetStaffById(idStaff);

            txtName.Text = staff.fullName;
            txtPhoneNumber.Text = staff.phone;
            txtEmail.Text = staff.address;   
          
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            Staff staff = StaffController.GetStaffById(idStaff);
            Account acc = AccountController.GetAccountByUsername(staff.userName);
            if (acc != null)
            {
                if (acc.password.Equals(txtOldPassword.Text) && txtNewPassword.Text.Equals(txtRepeatPassword.Text))
                {
                    bool result = AccountController.UpdatePassword(acc.userName, txtOldPassword.Text, txtNewPassword.Text);
                    if (result)
                    {
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtOldPassword.Text = string.Empty;
                        txtNewPassword.Text = string.Empty;
                        txtRepeatPassword.Text = string.Empty;  
                    } else
                    {
                        MessageBox.Show("Thay đổi mật khẩu thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ hoặc Xác nhận mật khẩu chưa chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}
