using HotelManager.Admin;
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

namespace HotelManager.NhanVien
{
    public partial class UC_Customer : UserControl
    {
        BindingSource customerList = new BindingSource();
        BindingSource receiptList = new BindingSource();

        public UC_Customer()
        {
            InitializeComponent();
            LoadCustomer();
        }

        void LoadCustomer()
        {
            dataGVCustomer.DataSource = customerList;
            loadCustomerList();
            AddCustomerBinding();
            txtCustomerID.ReadOnly= true;
            txtCustomerPoint.ReadOnly = true;
        }

        void loadCustomerList()
        {
            DataTable customers = CustomerController.GetCustomerList();
            customerList.DataSource = customers;
        }

        void loadCompleteReservationtByCustomerID(string id)
        {
            DataTable receipts = ReservationController.GetReservationByCustomerID(id);
            receiptList.DataSource = receipts;
        }


        void AddCustomerBinding()
        {
            txtCustomerID.DataBindings.Clear();
            txtCustomerName.DataBindings.Clear();
            mtxtCustomerDob.DataBindings.Clear();
            txtCustomerEm.DataBindings.Clear();
            txtCustomerPhone.DataBindings.Clear();
            txtCustomerIDNum.DataBindings.Clear();  
            txtCustomerPoint.DataBindings.Clear();

            txtCustomerID.DataBindings.Add("Text", dataGVCustomer.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never);
            txtCustomerName.DataBindings.Add("Text", dataGVCustomer.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            mtxtCustomerDob.DataBindings.Add("Text", dataGVCustomer.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtCustomerEm.DataBindings.Add("Text", dataGVCustomer.DataSource, "Email", true, DataSourceUpdateMode.Never);
            txtCustomerPhone.DataBindings.Add("Text", dataGVCustomer.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtCustomerIDNum.DataBindings.Add("Text", dataGVCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            txtCustomerPoint.DataBindings.Add("Text", dataGVCustomer.DataSource, "Tổng điểm", true, DataSourceUpdateMode.Never);
        }

        //private void btnAddCustomer_Click(object sender, EventArgs e)
        //{
        //    InsertCustomerForm insertStaffForm = new InsertCustomerForm();
        //    insertStaffForm.Show();
        //    LoadCustomer();
        //}

        void UpdateCustomer(string id, string hoTen, string email, DateTime ngaySinh, string sdt, string cmnd)
        {
            bool result = CustomerController.UpdateCustomer(id, hoTen, ngaySinh, email, sdt, cmnd);

            if (result)
            {
                MessageBox.Show("Sửa khách hành thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa khách hàng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string cusID = txtCustomerID.Text;
            string staffName = txtCustomerName.Text;
            DateTime staffBirth = DateTime.ParseExact(mtxtCustomerDob.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string staffPhone = txtCustomerPhone.Text;
            string email = txtCustomerEm.Text;
            string cmnd = txtCustomerIDNum.Text;

            UpdateCustomer(cusID, staffName, email, staffBirth, staffPhone, cmnd);
            LoadCustomer();
        }

        private void dataGVCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGVCustomer.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                string id = dataGVCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
                dataGVReceipt.ClearSelection();
                loadCompleteReservationtByCustomerID(id);
                dataGVReceipt.DataSource = receiptList;
            }
            else if (e.RowIndex < 0)
            {
                MessageBox.Show("Bấm lung tung thế!", "Thông báo");

            }
        }

        private void tabKhachHang_Click(object sender, EventArgs e)
        {
            string id = txtCustomerID.Text;
            loadCompleteReservationtByCustomerID(id);
            dataGVReceipt.DataSource = receiptList;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn thêm thành viên mới?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var form = new InsertNewCustomer())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        LoadCustomer();
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
    }
}
