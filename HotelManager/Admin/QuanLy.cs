using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using HotelManager.DAO;
using HotelManager.Controller;
using HotelManager.Helper;
using Button = System.Windows.Forms.Button;
using System.Globalization;

namespace HotelManager.Admin
{
    public partial class QuanLy : Form
    {
        private string staffUserName;

        BindingSource staffList = new BindingSource();
        BindingSource customerList = new BindingSource();
        BindingSource reservationList = new BindingSource();
        BindingSource receiptList = new BindingSource();

        public QuanLy(string userName)
        {
            InitializeComponent();

            this.staffUserName = userName;

            LoadRevenue();
            LoadStaff();
            LoadCustomer();
            LoadRoom();
            LoadReservation();

            lbUsername.Text = userName + " (Admin)";
            lbRoomFacility.Visible = false;

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
            Staff st = StaffController.GetStaffById(userName);
            DialogResult result = MessageBox.Show("Bạn có muốn xoá nhân viên " + st.fullName + "? ", "Xác nhận", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                bool deleteResult = StaffController.DeleteStaff(userName);

                if (deleteResult)
                {
                    MessageBox.Show("Xóa nhân viên thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại", "Thông báo");
                }
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Huỷ xóa nhân viên", "Thông báo");
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
            DateTime staffBirth = DateTime.ParseExact(dobStaff.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
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

        private void dataGVStaff_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dataGVStaff.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToString(Myrow.Cells[7].Value).Equals("Đã khoá"))// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Tomato;
                } else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Aquamarine;
                }
            }
        }

        //----------end staff module----------

        //----------start customer module----------

        void LoadCustomer()
        {
            dataGVCustomer.DataSource = customerList;
            loadCustomerList();
            AddCustomerBinding();
            txtCustomerId.ReadOnly = true;
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


        //----------begin room module----------
        void LoadRoom()
        {
            List<Room> list = RoomController.GetRoomList();
            foreach (Room room in list)
            {
                Button btn = new Button() { Width = RoomDAO.RoomBtnWidth, Height = RoomDAO.RoomBtnHeight };
                btn.Click += Btn_Click;
                btn.Tag = room;
                switch (room.isOccupied)
                {
                    case false:
                        btn.BackColor = Color.Aqua;
                        btn.Font = new Font(btn.Font.FontFamily, 14);
                        btn.Text = "Phòng " + room.roomNum + Environment.NewLine + "Trống";
                        break;
                    default:
                        btn.BackColor = Color.AntiqueWhite;
                        btn.Font = new Font(btn.Font.FontFamily, 14);
                        btn.Text = "Phòng " + room.roomNum + Environment.NewLine + "Đã đặt";
                        break;
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void showRoomInfo(int roomNum)
        {
            Room room = RoomController.loadRoombyRoomNum(roomNum);
            string roomFacility = RoomController.loadRoomFacility(roomNum);

            txtRoomNum.Text = room.roomNum.ToString();
            txtRoomName.Text = room.roomName.ToString();
            txtRoomType.Text = room.typeName.ToString();
            txtRoomArea.Text = room.area.ToString() + " m2";

            lbRoomFacility.Visible = true;
            lbRoomFacility.Font = new Font("Segoe UI", 11, FontStyle.Bold);
            lbRoomFacility.Text = roomFacility;
        }

        void Btn_Click(object sender, EventArgs e)
        {
            int roomNum = ((sender as Button).Tag as Room).roomNum;
            showRoomInfo(roomNum);
        }


        //----------end room module----------


        //----------begin reservation module----------

        void LoadReservation()
        {
            dataGVReservation.DataSource = reservationList;
            dataGVReservation.AllowUserToAddRows = false;
            LoadReservationList();
            AddReservationBinding();      
        }

        void LoadReservationList()
        {
            DataTable reservations = ReservationController.GetReservationList();
            reservationList.DataSource = reservations;
        }

        void AddReservationBinding()
        {
            txtReservationCustomerName.DataBindings.Clear();
            txtReservationCustomerEmail.DataBindings.Clear();
            txtReservationCustomerPhone.DataBindings.Clear();
            txtReservationCustomerCMND.DataBindings.Clear();
            txtReservationCustomerCheckin.DataBindings.Clear();
            txtReservationCustomerCheckout.DataBindings.Clear();
            txtStaffOrder.DataBindings.Clear();
            txtResTotalPrice.DataBindings.Clear();

            CultureInfo culture = new CultureInfo("vi-VN");

            txtReservationCustomerName.DataBindings.Add("Text", dataGVReservation.DataSource, "Khách hàng", true, DataSourceUpdateMode.Never);
            //txtReservationCustomerEmail.DataBindings.Add("Text", dataGVReservation.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            //txtReservationCustomerPhone.DataBindings.Add("Text", dataGVReservation.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            //txtReservationCustomerCMND.DataBindings.Add("Text", dataGVReservation.DataSource, "Email", true, DataSourceUpdateMode.Never);
            //txtReservationCustomerCheckin.DataBindings.Add("Text", dataGVReservation.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            //txtReservationCustomerCheckout.DataBindings.Add("Text", dataGVReservation.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            txtStaffOrder.DataBindings.Add("Text", dataGVReservation.DataSource, "Nhân viên", true, DataSourceUpdateMode.Never);
            txtReservationCustomerCheckin.DataBindings.Add("Text", dataGVReservation.DataSource, "Ngày Check-in", true, DataSourceUpdateMode.Never);
            txtReservationCustomerCheckout.DataBindings.Add("Text", dataGVReservation.DataSource, "Ngày Check-out thực tế", true, DataSourceUpdateMode.Never);
            txtResTotalPrice.DataBindings.Add("Text", dataGVReservation.DataSource, "Tổng tiền", true, DataSourceUpdateMode.Never);

        }

        private void dataGVReservation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dataGVReservation.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToDecimal(Myrow.Cells[9].Value) == 0)// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Aqua;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.MediumSpringGreen;
                }
            }
        }

        private void btnReservationSort_Click(object sender, EventArgs e)
        {
            LoadReservation();
        }

        private void tpRoomService_Click(object sender, EventArgs e)
        {
            int rowindex = dataGVReservation.CurrentCell.RowIndex;
            if (rowindex < 0)
            {
                return;
            }
            string idReservation = dataGVReservation.Rows[rowindex].Cells[0].Value.ToString();
            dataGVRoomServiceByRes.DataSource = ServiceReservationByRoomController.GetRoomServiceListByReservation(idReservation);
        }

        private void dataGVReservation_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGVReservation.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGVReservation.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGVReservation.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Mã đặt phòng"].Value);
                dataGVRoomServiceByRes.DataSource = ServiceReservationByRoomController.GetRoomServiceListByReservation(cellValue);
            }
        }

        //----------end reservation module----------


        //----------begin revenue module----------
        void LoadDateTimePickerRevenue()
        {
            dtpFromDate.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
        }

        void LoadRevenueByDate(DateTime fromDate, DateTime toDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            dataGVRevenue.DataSource = RevenueController.GetRevenueByDate(fromDate, toDate); ;
            txtRevenueTotal.Text = GetSumRevenue().ToString("c", culture);
        }

        void LoadRevenueByMonth(DateTime fromDate, DateTime toDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            dataGVRevenue.DataSource = RevenueController.GetRevenueByMonth(fromDate, toDate); ;
            txtRevenueTotal.Text = GetSumRevenue().ToString("c", culture);
        }

        void LoadRevenueByQuarter(DateTime fromDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            dataGVRevenue.DataSource = RevenueController.GetRevenueByQuarter(fromDate); ;
            txtRevenueTotal.Text = GetSumRevenue().ToString("c", culture);
        }

        void LoadRevenueByYear(DateTime fromDate, DateTime toDate)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            dataGVRevenue.DataSource = RevenueController.GetRevenueByYear(fromDate, toDate); ;
            txtRevenueTotal.Text = GetSumRevenue().ToString("c", culture);
        }

        void LoadRevenue()
        {
            LoadDateTimePickerRevenue();//Set "Từ ngày" & "Đến ngày ngày" về đầu tháng & cuối tháng
            LoadRevenueByDate(dtpFromDate.Value, dtpToDate.Value);
        }

        void LoadRevenueList()
        {
            DataTable reservations = ReservationController.GetReservationList();
            reservationList.DataSource = reservations;
            dataGVRevenue.DataSource = reservationList;
        }      

        decimal GetSumRevenue()
        {
            return RevenueController.GetTotalRevenue(dataGVRevenue);
        }
  

        private void tpRevenue_Enter(object sender, EventArgs e)
        {
            LoadRevenue();
        }

        private void btnRevenueByDate_Click(object sender, EventArgs e)
        {
            LoadRevenueByDate(dtpFromDate.Value, dtpToDate.Value);
        }

        private void btnRevenueByMonth_Click(object sender, EventArgs e)
        {
            LoadRevenueByMonth(dtpFromDate.Value, dtpToDate.Value);
        }

        private void btnRevenueByYear_Click(object sender, EventArgs e)
        {
            LoadRevenueByYear(dtpFromDate.Value, dtpToDate.Value);
        }

        private void btnExcelOutput_Click(object sender, EventArgs e)
        {
            Validation.Export2Excel(dataGVRevenue);
        }

        private void btnRevenueByQuarter_Click(object sender, EventArgs e)
        {
            LoadRevenueByQuarter(dtpFromDate.Value);
        }
    }
}