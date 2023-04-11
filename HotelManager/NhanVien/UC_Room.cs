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
    public partial class UC_Room : UserControl
    {
        public UC_Room()
        {
            InitializeComponent();
            LoadRoom();
        }

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

        //void showRoomInfo(int roomNum)
        //{
        //    Room room = RoomController.loadRoombyRoomNum(roomNum);
        //    string roomFacility = RoomController.loadRoomFacility(roomNum);

        //    txtRoomNum.Text = room.roomNum.ToString();
        //    txtRoomName.Text = room.roomName.ToString();
        //    txtRoomType.Text = room.typeName.ToString();
        //    txtRoomArea.Text = room.area.ToString() + " m2";

        //    lbRoomFacility.Visible = true;
        //    lbRoomFacility.Font = new Font("Segoe UI", 12, FontStyle.Bold);
        //    lbRoomFacility.Text = roomFacility;
        //}

        void Btn_Click(object sender, EventArgs e)
        {
            int roomNum = ((sender as Button).Tag as Room).roomNum;
            //showRoomInfo(roomNum);
        }

    }
}
