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
    public partial class UC_Facility : UserControl
    {
        public UC_Facility()
        {
            InitializeComponent();
            LoadVatTu(); 
            LoadRoom();
        }

        void LoadVatTu()
        {
            dataGVVatTu.DataSource = RoomThingController.GetRoomThingsTable();
        }

        void LoadRoom()
        {
            List<Room> list = RoomController.GetRoomList();
            foreach (Room room in list)
            {
                Button btn = new Button() { Width = RoomDAO.RoomBtnWidth, Height = RoomDAO.RoomBtnHeight };
                btn.Click += Btn_Click;
                btn.Tag = room;
                if (!room.isOccupied && !room.isClean)
                {
                    btn.BackColor = Color.Chocolate;
                    btn.ForeColor = Color.AntiqueWhite;
                    btn.Font = new Font(btn.Font.FontFamily, 14);
                    btn.Text = "Phòng " + room.roomNum + Environment.NewLine + "Đang sửa";

                }
                else if (!room.isOccupied)
                {
                    btn.BackColor = Color.AntiqueWhite;
                    btn.ForeColor = Color.Salmon;
                    btn.Font = new Font(btn.Font.FontFamily, 14);
                    btn.Text = "Phòng " + room.roomNum + Environment.NewLine + "Trống";

                }
                else
                {
                    btn.BackColor = Color.Salmon;
                    btn.ForeColor = Color.AntiqueWhite;
                    btn.Font = new Font(btn.Font.FontFamily, 14);
                    btn.Text = "Phòng " + room.roomNum + Environment.NewLine + "Đã đặt";
                }
                flowLayoutPanel1.Controls.Add(btn);
            }
        }

        void Btn_Click(object sender, EventArgs e)
        {
            int roomNum = ((sender as Button).Tag as Room).roomNum;
            showRoomThingsInfo(roomNum);
        }

        void showRoomThingsInfo(int roomNum)
        {
            dataGVRoomThings.DataSource = RoomThingController.GetRoomThingsTableByRoomNum((short)roomNum);         
        }

        private void btnAddRoomThings_Click(object sender, EventArgs e)
        {

        }
    }
}
