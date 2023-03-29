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

namespace HotelManager.Admin
{
    public partial class InsertStaffForm : Form
    {
        public InsertStaffForm()
        {
            InitializeComponent();
        }

        void AddStaff(string hoTen, DateTime ngaySinh, string diaChi, string sdt, string cmnd)
        {
            bool result = StaffController.InsertStaff(hoTen, ngaySinh, diaChi, sdt, cmnd);

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
            string staffName = txtStaffName.Text;
            DateTime staffBirth = DateTime.ParseExact(txtStaffDob.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string staffAddress = txtStaffAddress.Text;
            string staffPhone = txtStaffPhone.Text;
            string staffINumber = txtStaffINumber.Text;

            AddStaff(staffName, staffBirth, staffAddress, staffPhone, staffINumber);
        }
    }
}
