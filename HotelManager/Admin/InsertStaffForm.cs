using HotelManager.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.Helper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web.Security;
using System.Xml.Linq;

namespace HotelManager.Admin
{
    public partial class InsertStaffForm : Form
    {
        public InsertStaffForm()
        {
            InitializeComponent();

            dtpStaffBirth.Format = DateTimePickerFormat.Custom;
            dtpStaffBirth.CustomFormat = "dd/MM/yyyy";
        }

        void AddStaff(string hoTen, DateTime ngaySinh, string diaChi, string sdt, string cmnd, string pass, short count)
        {
            bool result = StaffController.InsertStaff(hoTen, ngaySinh, diaChi, sdt, cmnd, pass, count);

            if (result)
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }

        private void btnInsertStaff_Click(object sender, EventArgs e)
        {
            if (txtStaffAddress.Text != "" && txtStaffINumber.Text != "" && txtStaffName.Text != ""
                            && txtStaffPhone.Text != "")
            {
                if (Validation.IsValidEmail(txtStaffAddress.Text) && Validation.IsPhoneNumber(txtStaffPhone.Text))
                {
                    if (Validation.check18YearsOldInAge(dtpStaffBirth.Value))
                    {
                        string password = Support.GetRandomPassword();
                        bool result = StaffController.InsertStaff(txtStaffName.Text, dtpStaffBirth.Value, txtStaffAddress.Text, txtStaffPhone.Text, txtStaffINumber.Text, password, 0);
                        if (result)
                        {

                            SendMail sendMail = new SendMail(txtStaffAddress.Text, password);
                            sendMail.ShowDialog();
                            MessageBox.Show(sendMail.Result);
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                            MessageBox.Show("Không thêm nhân viên được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else MessageBox.Show("Nhân viên chưa đủ 18 tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }
                else MessageBox.Show("Email không đúng định dạng hay số điện thoại chưa đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else MessageBox.Show("Thiếu thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

        }
    }
}
