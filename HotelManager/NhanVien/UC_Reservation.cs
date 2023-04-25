using HotelManager.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.NhanVien
{
    public partial class UC_Reservation : UserControl
    {
        BindingSource reservationList = new BindingSource();

        public UC_Reservation()
        {
            InitializeComponent();
            LoadReservation();
        }

        void LoadReservation()
        {
            dataGVReservation.DataSource = reservationList;
            dataGVReservation.AllowUserToAddRows = false;
            LoadReservationList();
            AddReservationBinding();
        }
        void LoadReservationByDate(DateTime from, DateTime to)
        {
            dataGVReservation.DataSource = ReservationController.GetReservationByDate(from, to);
            dataGVReservation.AllowUserToAddRows = false;
            AddReservationBinding();
        }

        void LoadReservationList()
        {
            DataTable reservations = ReservationController.GetReservationList();
            reservationList.DataSource = reservations;
        }

        void AddReservationBinding()
        {
            txtReservationID.DataBindings.Clear();
            txtReservationCustomerName.DataBindings.Clear();
            txtReservationCustomerEmail.DataBindings.Clear();
            txtReservationCustomerPhone.DataBindings.Clear();
            txtReservationCustomerCMND.DataBindings.Clear();
            txtReservationCustomerCheckin.DataBindings.Clear();
            txtReservationCustomerCheckout.DataBindings.Clear();
            txtStaffOrder.DataBindings.Clear();
            txtResTotalPrice.DataBindings.Clear();

            CultureInfo culture = new CultureInfo("vi-VN");

            txtReservationID.DataBindings.Add("Text", dataGVReservation.DataSource, "Mã đặt phòng", true, DataSourceUpdateMode.Never);
            txtReservationCustomerName.DataBindings.Add("Text", dataGVReservation.DataSource, "Tên khách hàng", true, DataSourceUpdateMode.Never);
            //txtReservationCustomerEmail.DataBindings.Add("Text", dataGVReservation.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            txtReservationCustomerPhone.DataBindings.Add("Text", dataGVReservation.DataSource, "SĐT khách hàng", true, DataSourceUpdateMode.Never);
            //txtReservationCustomerCMND.DataBindings.Add("Text", dataGVReservation.DataSource, "Email", true, DataSourceUpdateMode.Never);
            //txtReservationCustomerCheckin.DataBindings.Add("Text", dataGVReservation.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            //txtReservationCustomerCheckout.DataBindings.Add("Text", dataGVReservation.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            txtStaffOrder.DataBindings.Add("Text", dataGVReservation.DataSource, "Nhân viên", true, DataSourceUpdateMode.Never);
            txtReservationCustomerCheckin.DataBindings.Add("Text", dataGVReservation.DataSource, "Ngày Check-in", true, DataSourceUpdateMode.Never);
            txtReservationCustomerCheckout.DataBindings.Add("Text", dataGVReservation.DataSource, "Ngày Check-out thực tế", true, DataSourceUpdateMode.Never);
            txtResTotalPrice.DataBindings.Add("Text", dataGVReservation.DataSource, "Tổng tiền", true, DataSourceUpdateMode.Never);
        }

        void showCustomerInfo(string cusPhone)
        {
            Customer cus = CustomerController.GetCustomerByPhone(cusPhone);
            if (cus != null)
            {
                txtReservationCustomerEmail.Text = cus.email;
                txtReservationCustomerCMND.Text = cus.cmnd;
                txtReservationCustomerPhone.Text = cus.phone;
            }
        }

        private void btnReservationSort_Click(object sender, EventArgs e)
        {
            LoadReservationByDate(dtpFromDate.Value, dtpToDate.Value);
        }

        private void dataGVReservation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dataGVReservation.Rows)
            {            
                
                if (Convert.ToDecimal(Myrow.Cells[10].Value) == 0)// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Aqua;
                }
                else if (Convert.ToString(Myrow.Cells[9].ToString()).Equals("Đã thanh toán") && Convert.ToDecimal(Myrow.Cells[10].Value) == 0)
                {
                    Myrow.DefaultCellStyle.BackColor = Color.SaddleBrown;
                } else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.MediumSpringGreen;
                }
            }
        }

        private void dataGVReservation_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGVReservation.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGVReservation.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGVReservation.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Mã đặt phòng"].Value);
                string cusPhone = Convert.ToString(selectedRow.Cells["SĐT khách hàng"].Value);
                dataGridView1.DataSource = ServiceReservationByRoomController.GetRoomServiceListByReservation(cellValue);

                CultureInfo culture = new CultureInfo("vi-VN");
                txtServiceTotalPrice.Text = ServiceReservationByRoomController.GetServiceTotalPrice(dataGridView1).ToString("c", culture);
                showCustomerInfo(cusPhone);
            }
        }
    }
}
