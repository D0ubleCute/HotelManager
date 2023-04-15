﻿using HotelManager.Controller;
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
    }
}
