using HotelManager.Controller;
using HotelManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.NhanVien
{
    public partial class NV : Form
    {
        public string StaffID;
        

        public NV(string userName)
        {
            InitializeComponent();
            Staff staff = StaffController.GetStaffByUserName(userName);

            StaffID = staff.id;

            label3.Text += "Bonjour" + Environment.NewLine + staff.fullName;
            lblStaffUsername.Text = staff.fullName;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);   
            userControl.BringToFront(); 
        }

        private void btnStaffReservation_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            UC_Reservation reservationOrder = new UC_Reservation();
            addUserControl(reservationOrder);
        }

        private void btnStaffRoom_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            UC_Room room = new UC_Room(StaffID);
            addUserControl(room);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStaffService_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            UC_Service uC_Customer = new UC_Service();
            addUserControl(uC_Customer);
        }

        private void btnStaffFacility_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            UC_Facility uC_Customer = new UC_Facility();
            addUserControl(uC_Customer);
        }

        private void btnStaffCustomer_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            UC_Customer uC_Customer = new UC_Customer();
            addUserControl(uC_Customer);
        }

        private void btnStaffSettings_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            UC_AccountSetting accountSetting = new UC_AccountSetting(StaffID);
            addUserControl(accountSetting);
        }
    }
}
