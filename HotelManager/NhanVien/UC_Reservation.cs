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
            loadReservationList();
            //AddReservationBinding();
        }

        void loadReservationList()
        {
            DataTable reservations = ReservationController.GetReservationList();
            reservationList.DataSource = reservations;
        }

        private void dataGVReservation_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow Myrow in dataGVReservation.Rows)
            {            //Here 2 cell is target value and 1 cell is Volume
                if (Convert.ToString(Myrow.Cells[4].Value) == null || Convert.ToString(Myrow.Cells[4].Value).Equals(""))// Or your condition 
                {
                    Myrow.DefaultCellStyle.BackColor = Color.Aqua;
                }
                else
                {
                    Myrow.DefaultCellStyle.BackColor = Color.MediumSpringGreen;
                }
            }
        }



        //void AddReservationBinding()
        //{
        //    txtReservationCustomerName.DataBindings.Clear();
        //    txtReservationCustomerEmail.DataBindings.Clear();
        //    txtReservationCustomerPhone.DataBindings.Clear();
        //    txtReservationCustomerCMND.DataBindings.Clear();
        //    txtReservationCustomerCheckin.DataBindings.Clear();
        //    txtReservationCustomerCheckout.DataBindings.Clear();
        //    txtStaffOrder.DataBindings.Clear();
        //    lblMoney.DataBindings.Clear();

        //    CultureInfo culture = new CultureInfo("vi-VN");

        //    txtReservationCustomerName.DataBindings.Add("Text", dataGVReservation.DataSource, "Khách hàng", true, DataSourceUpdateMode.Never);
        //    //txtReservationCustomerEmail.DataBindings.Add("Text", dataGVReservation.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
        //    //txtReservationCustomerPhone.DataBindings.Add("Text", dataGVReservation.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
        //    //txtReservationCustomerCMND.DataBindings.Add("Text", dataGVReservation.DataSource, "Email", true, DataSourceUpdateMode.Never);
        //    //txtReservationCustomerCheckin.DataBindings.Add("Text", dataGVReservation.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
        //    //txtReservationCustomerCheckout.DataBindings.Add("Text", dataGVReservation.DataSource, "CMND", true, DataSourceUpdateMode.Never);
        //    txtStaffOrder.DataBindings.Add("Text", dataGVReservation.DataSource, "Nhân viên", true, DataSourceUpdateMode.Never);
        //    txtReservationCustomerCheckin.DataBindings.Add("Text", dataGVReservation.DataSource, "Check-in", true, DataSourceUpdateMode.Never);
        //    txtReservationCustomerCheckout.DataBindings.Add("Text", dataGVReservation.DataSource, "Check-out", true, DataSourceUpdateMode.Never);
        //    lblMoney.DataBindings.Add("Text", dataGVReservation.DataSource, "Tổng tiền", true, DataSourceUpdateMode.Never);

        //    //decimal curr = Convert.ToDecimal(lblMoney.Text);
        //    //lblMoney.Text = curr.ToString("c", culture);
        //}


    }
}
