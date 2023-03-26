using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.DAO;
using HotelManager.Controller;

namespace HotelManager.Admin
{
    public partial class QuanLy : Form
    {
        private string staffUserName;

        BindingSource staffList = new BindingSource();
        BindingSource customerList = new BindingSource();
        BindingSource productList = new BindingSource();
        BindingSource receiptList = new BindingSource();

        public QuanLy(string userName)
        {
            InitializeComponent();

            this.staffUserName = userName;

            LoadStaff();

            lbUserName.Text = userName + " (Admin)";
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpRevenue;
        }

        private void btnRevenue_MouseLeave(object sender, EventArgs e)
        {
            btnRevenue.BackColor = Color.White;
            btnRevenue.ForeColor = Color.Black;
        }

        private void btnRevenue_MouseHover(object sender, EventArgs e)
        {
            btnRevenue.BackColor = Color.FromArgb(220, 174, 117);
            btnRevenue.ForeColor = Color.FromArgb(247, 229, 20);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            btnStaff.BackColor = Color.White;
            btnStaff.ForeColor = Color.AliceBlue;
            tabControl1.SelectedTab = tpStaff;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            btnCustomer.BackColor = Color.White;
            btnCustomer.ForeColor = Color.AliceBlue;
            tabControl1.SelectedTab = tpCustomer;
        }

        private void btnFacility_Click(object sender, EventArgs e)
        {
            btnFacility.BackColor = Color.White;
            btnFacility.ForeColor = Color.AliceBlue;
            tabControl1.SelectedTab = tpFacility;
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            btnReservation.BackColor = Color.White;
            btnReservation.ForeColor = Color.AliceBlue;
            tabControl1.SelectedTab = tpReservation;
        }

        ////----------begin staff module----------
        void LoadStaff()
        {
            dataGVStaff.DataSource = staffList;
            LoadStaffList();
            AddStaffBinding();
        }

        void LoadStaffList()
        {
            DataTable staffs = StaffController.GetStaffList();
            staffList.DataSource = staffs;
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            LoadStaff();
        }

        void AddStaffBinding()
        {
            txtStaffId.DataBindings.Clear();
            txtStaffName.DataBindings.Clear();
            dobStaff.DataBindings.Clear();
            txtStaffAddress.DataBindings.Clear();
            txtStaffPhone.DataBindings.Clear();
            txtStaffINumber.DataBindings.Clear();
            picStaff.DataBindings.Clear();

            txtStaffId.DataBindings.Add("Text", dataGVStaff.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never);
            txtStaffName.DataBindings.Add("Text", dataGVStaff.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            dobStaff.DataBindings.Add("Text", dataGVStaff.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtStaffAddress.DataBindings.Add("Text", dataGVStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtStaffPhone.DataBindings.Add("Text", dataGVStaff.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtStaffINumber.DataBindings.Add("Text", dataGVStaff.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            picStaff.DataBindings.Add("Text", dataGVStaff.DataSource, "CMND", true, DataSourceUpdateMode.Never);
        }

        private void btnShowCustomer_Click(object sender, EventArgs e)
        {

        }
    }
}
