using HotelManager.Controller;
using HotelManager.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HotelManager.NhanVien
{
    public partial class InsertNewCustomer : Form
    {
        public InsertNewCustomer()
        {
            InitializeComponent();

            dtpCusBirth.Format = DateTimePickerFormat.Custom;
            dtpCusBirth.CustomFormat = "dd/MM/yyyy";
        }

        void AddCustomer(string hoTen, DateTime ngaySinh, string email, string sdt, string cmnd)
        {
            bool result = CustomerController.InsertCustomer(hoTen, ngaySinh, email, "", sdt, cmnd);

            if (result)
            {
                MessageBox.Show("Thêm khách hàng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInsertCus_Click(object sender, EventArgs e)
        {
            if (txtCusEmail.Text != "" && txtCusINumber.Text != "" && txtCusName.Text != ""
                            && txtCusPhone.Text != "")
            {
                if (Validation.IsValidEmail(txtCusEmail.Text) && Validation.IsPhoneNumber(txtCusPhone.Text))
                {
                    if (Validation.check18YearsOldInAge(dtpCusBirth.Value))
                    {
                        bool result = CustomerController.InsertCustomer(txtCusName.Text, dtpCusBirth.Value, txtCusEmail.Text, "", txtCusPhone.Text, txtCusINumber.Text);

                        if (result)
                        {
                            MessageBox.Show("Thêm thành viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                        else
                            MessageBox.Show("Không thêm thành viên được được", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    else MessageBox.Show("Khách hành chưa đủ 18 tuổi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
