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
using HotelManager.Helper;

namespace HotelManager.NhanVien
{
    public partial class CreateReservation : Form
    {
        public short accoType { get; set; }
        public DateTime checkInDate { get; set; }
        public DateTime checkOutDate { get; set; }
        public string cusPhone { get; set; }
        public DialogResult Result { get; set; }


        public CreateReservation(string roomNum)
        {
            InitializeComponent();

            lbRoomNum.Text = roomNum;

            cbbAccomodation.SelectedIndex = 0;

            dtpCheckin.Format = DateTimePickerFormat.Custom;
            dtpCheckin.CustomFormat = "MM/dd/yyyy HH:mm";
            dtpCheckout.Format = DateTimePickerFormat.Custom;
            dtpCheckout.CustomFormat = "MM/dd/yyyy HH:mm";

            dtpCheckin.Value = DateTime.Now;
            dtpCheckout.Value = DateTime.Now;        
        }

        private void btnConfirmCreateRes_Click(object sender, EventArgs e)
        {
            accoType = Convert.ToInt16(cbbAccomodation.Text);

            checkInDate = dtpCheckin.Value;
            checkOutDate = dtpCheckout.Value;

            if (!Validation.checkPastDate(checkInDate.Date) || !Validation.checkPastDate(checkOutDate.Date))
            {
                MessageBox.Show("Không thể chọn ngày từ quá khứ!", "Cảnh báo");
                return;
            }
            
            if(accoType == 1)
            {
                checkOutDate = DateTime.Now;
            } else if (accoType == 2)
            {
                TimeSpan ts1 = new TimeSpan(22, 00, 00);
                checkInDate = checkInDate.Date + ts1;

                TimeSpan ts2 = new TimeSpan(12, 00, 00);
                checkOutDate = checkOutDate.Date + ts2;
            } else
            {
                TimeSpan ts1 = new TimeSpan(14, 00, 00);
                checkInDate = checkInDate.Date + ts1;

                TimeSpan ts2 = new TimeSpan(12, 00, 00);
                checkOutDate = checkOutDate.Date + ts2;
            }

            cusPhone = txtCustomerInfo.Text;

            DialogResult = DialogResult.OK;

            Close();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }    
    }
}
