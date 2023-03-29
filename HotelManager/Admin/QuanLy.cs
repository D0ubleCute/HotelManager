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
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

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
            LoadCustomer();
            LoadRoom();

            lbUserName.Text = userName + " (Admin)";

            tabControl1.SelectedTab = tpStaff;
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
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
            tabControl1.SelectedTab = tpStaff;
            if ((tabControl1.SelectedTab == tpStaff))
            {
                btnStaff.BackColor = Color.White;
                btnStaff.ForeColor = Color.BurlyWood;
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            
            tabControl1.SelectedTab = tpCustomer;
            if ((tabControl1.SelectedTab == tpCustomer))
            {
                btnCustomer.BackColor = Color.White;
                btnCustomer.ForeColor = Color.BurlyWood;
            }
        }

        private void btnFacility_Click(object sender, EventArgs e)
        {         
            tabControl1.SelectedTab = tpFacility;
            if ((tabControl1.SelectedTab == tpFacility))
            {
                btnFacility.BackColor = Color.White;
                btnFacility.ForeColor = Color.BurlyWood;
            }
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tpReservation;
            if ((tabControl1.SelectedTab == tpReservation))
            {
                btnReservation.BackColor = Color.White;
                btnReservation.ForeColor = Color.BurlyWood;
            }

        }

        ////----------begin staff module----------
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
            txtStaffId.ReadOnly = true;
            txtStaffName.DataBindings.Add("Text", dataGVStaff.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            dobStaff.DataBindings.Add("Text", dataGVStaff.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtStaffAddress.DataBindings.Add("Text", dataGVStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtStaffPhone.DataBindings.Add("Text", dataGVStaff.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtStaffINumber.DataBindings.Add("Text", dataGVStaff.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            picStaff.DataBindings.Add("Text", dataGVStaff.DataSource, "CMND", true, DataSourceUpdateMode.Never);
        }


        void LoadStaffList()
        {
            DataTable staffs = StaffController.GetStaffList();
            staffList.DataSource = staffs;
        }

        void LoadStaff()
        {
            dataGVStaff.DataSource = staffList;
            LoadStaffList();
            AddStaffBinding();
        }

        void UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, string cmnd)
        {
            bool result = StaffController.UpdateStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd);

            if (result)
            {
                MessageBox.Show("Sửa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }

        void DeleteStaff(string userName)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá nhân viên này?", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                bool deleteResult = StaffController.DeleteStaff(userName);

                if (deleteResult)
                {
                    MessageBox.Show("Xóa nhân viên thành công");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại");
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Huỷ xóa nhân viên thất bại");
            }
           
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            LoadStaff();
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            InsertStaffForm insertStaffForm = new InsertStaffForm();
            insertStaffForm.Show();
            LoadStaff(); 
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            string staffName = txtStaffName.Text;
            DateTime staffBirth = DateTime.Parse(dobStaff.Text);
            string staffAddress = txtStaffAddress.Text;
            string staffPhone = txtStaffPhone.Text;
            string staffINumber = txtStaffINumber.Text;
            UpdateStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber);
            LoadStaffList();
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            DeleteStaff(staffId);
            LoadStaffList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            {
                string searchValue = txtSearch.Text.ToLower();
                dataGVStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    bool valueResult = false;
                    foreach (DataGridViewRow row in dataGVStaff.Rows)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Equals(searchValue))
                            {
                                int rowIndex = row.Index;
                                dataGVStaff.Rows[rowIndex].Selected = true;
                                valueResult = true;
                                break;
                            }
                        }

                    }
                    if (!valueResult)
                    {
                        MessageBox.Show("Không tìm thấy " + txtSearch.Text, "Thông báo");
                        return;
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            //staffList.Filter = null;

            //if (String.IsNullOrEmpty(txtSearch.Text.Trim()))
            //{
            //    LoadStaff();
            //    return;
            //}

            //string strKey = txtSearch.Text.Trim().ToLower().ToString();

            //StringBuilder stringBuilder = new StringBuilder();
            //stringBuilder.AppendFormat("(Convert(Mã_nhân_viên, 'System.String') LIKE '" + "{0}" + "')", strKey);
            //stringBuilder.AppendFormat("OR (Họ_tên LIKE '*" + "{0}" + "*')", strKey);
            //stringBuilder.AppendFormat("OR (SĐT LIKE '*" + "{0}" + "*')", strKey);
            //stringBuilder.AppendFormat("OR (CMND LIKE '*" + "{0}" + "*')", strKey);
            //stringBuilder.AppendFormat("OR (Trạng_thái LIKE '*" + "{0}" + "*')", strKey);

            //string strFilter = stringBuilder.ToString();
            //staffList.Filter = strFilter;

            //if (staffList.Count != 0)
            //{
            //    dataGVStaff.DataSource = staffList;
            //} else
            //{
            //    MessageBox.Show("Không tìm thấy nội dung", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    LoadStaff();
            //    return;
            //}
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.SuppressKeyPress = true;
                //mute ting sound
            }
        }

        void LockOrUnlockAccount()
        {
            string userName = txtStaffId.Text;
            bool checkReset = StaffController.LockOrUnLockStaffAccount(userName);
            if (checkReset)
            {
                MessageBox.Show("Mở/Khoá tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hành động này không thể thực hiện", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUnlockAccount_Click(object sender, EventArgs e)
        {
            LockOrUnlockAccount();
            LoadStaff();
        }
 

        //----------end staff module----------

        //----------start customer module----------

        void LoadCustomer()
        {
            dataGVCustomer.DataSource = customerList;
            loadCustomerList();
            AddCustomerBinding();
        }

        void loadCustomerList()
        {
            DataTable customers = CustomerController.GetCustomerList();
            customerList.DataSource = customers;
        }

        void AddCustomerBinding()
        {
            txtCustomerId.DataBindings.Clear();
            txtCustomerName.DataBindings.Clear();
            dobCustomer.DataBindings.Clear();
            txtCustomerEmail.DataBindings.Clear();
            txtCustomerPhone.DataBindings.Clear();
            txtCustomerINumber.DataBindings.Clear();

            txtCustomerId.DataBindings.Add("Text", dataGVCustomer.DataSource, "Mã khách hàng", true, DataSourceUpdateMode.Never);
            txtCustomerName.DataBindings.Add("Text", dataGVCustomer.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            dobCustomer.DataBindings.Add("Text", dataGVCustomer.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtCustomerEmail.DataBindings.Add("Text", dataGVCustomer.DataSource, "Email", true, DataSourceUpdateMode.Never);
            txtCustomerPhone.DataBindings.Add("Text", dataGVCustomer.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtCustomerINumber.DataBindings.Add("Text", dataGVCustomer.DataSource, "CMND", true, DataSourceUpdateMode.Never);
        }

        private void btnShowCustomer_Click_1(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        //----------end customer module----------

        void LoadRoom()
        {
            List<Room> list = RoomController.GetRoomList();
            foreach (Room room in list)
            {
                Button btn = new Button() { Width = RoomDAO.RoomBtnWidth, Height = RoomDAO.RoomBtnHeight };
                switch (room.isOccupied)
                {
                    case false:
                        btn.BackColor = Color.Azure;
                        btn.Text = "Phòng " + room.roomNum + Environment.NewLine + "Trống";
                        break;
                    default:
                        btn.BackColor = Color.AntiqueWhite;
                        btn.Text = "Phòng " + room.roomNum + Environment.NewLine + "Đã đặt";
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }
    }
}
