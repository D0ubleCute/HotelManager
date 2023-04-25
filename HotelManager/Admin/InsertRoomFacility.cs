using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.Controller;

namespace HotelManager.Admin
{
    public partial class InsertRoomFacility : Form
    {
        public short roomNum;
        public DialogResult Result { get; set; }

        public InsertRoomFacility(short roomNumb)
        {
            InitializeComponent();
            roomNum = roomNumb;
        }   

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Close();    
        }

        bool AddRoomFacility(short roomNum, string nameFacility)
        {
            
            bool result = RoomFacilityController.InsertRoomFacility(nameFacility, roomNum);

            if (result)
            {
                MessageBox.Show("Thêm CSVC cho phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("Thêm CSVC cho phòng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnInsertRoomFacility_Click(object sender, EventArgs e)
        {
            if (txtNameFacility == null || txtNameFacility.Text.Length == 0)
            {
                MessageBox.Show("Không được để trống", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            bool result = AddRoomFacility(roomNum, txtNameFacility.Text);

            if (result)
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }
    }
}
