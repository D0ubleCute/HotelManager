using HotelManager.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.NhanVien
{
    public partial class CreateReservation : Form
    {
        public CreateReservation(string roomNum, string idStaff)
        {
            InitializeComponent();

            lbRoomNum.Text = roomNum;
            txtStaffInfo.Text = idStaff;
        }

        void AddReservation(short roomNum, short accomType,
                                           DateTime checkIn, DateTime checkOut, string idCus, string idStaff)
        {
            bool result = ReservationController.InsertReservation(roomNum, accomType, checkIn, checkOut, idCus, idStaff);

            if (result)
            {
                MessageBox.Show("Tạo đơn đặt phòng thành công", "Thành công");
                this.Close();
            }
            else
            {
                MessageBox.Show("Tạo đơn đặt phòng thành công thất bại", "Lỗi", (MessageBoxButtons)MessageBoxIcon.Error);
            }
        }

        private void btnConfirmCreateRes_Click(object sender, EventArgs e)
        {
            short roomNumB = Convert.ToInt16(lbRoomNum.Text);

            
            short acco = Convert.ToInt16(cbbAccomodation.Text);

            DateTime checkin = dtpCheckin.Value;
            DateTime checkout = dtpCheckout.Value;
            string idCus = txtCustomerInfo.Text;
            string idStaff = txtStaffInfo.Text;

            AddReservation(roomNumB, acco, checkin, checkout, idCus, idStaff);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
