using HotelManager.Controller;
using HotelManager.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManager.NhanVien
{
    public partial class UC_Room : UserControl
    {
        public UC_Room(string idStaff)
        {
            InitializeComponent();
            LoadRoom();
            label1.Text = idStaff;
        }

        void LoadRoom()
        {
            List<Room> list = RoomController.GetRoomList();
            foreach (Room room in list)
            {
                Button btn = new Button() { Width = RoomDAO.RoomBtnWidth, Height = RoomDAO.RoomBtnHeight };
                btn.Click += Btn_Click;
                btn.Tag = room;
                btn.ForeColor = Color.WhiteSmoke;
                switch (room.isOccupied)
                {
                    case false:
                        btn.BackColor = Color.AntiqueWhite;
                        btn.ForeColor = Color.Salmon;
                        btn.Font = new Font(btn.Font.FontFamily, 14);
                        btn.Text = "Phòng " + room.roomNum + Environment.NewLine + "Trống";
                        break;
                    default:
                        btn.BackColor = Color.Salmon;
                        btn.ForeColor = Color.AntiqueWhite;
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

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            if(txtRoomNum.Text == null || txtRoomNum.Text.Equals("")) {
                MessageBox.Show("Hãy chọn 1 phòng", "Xác nhận");
                LoadRoom();
                return;
            }

            string roomNum = txtRoomNum.Text;
            DialogResult dialogResult = MessageBox.Show("Bạn muốn tạo đơn đặt phòng mới?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                CreateReservation createReservation = new CreateReservation(roomNum, label1.Text);
                createReservation.ShowDialog();
                LoadRoom();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
            LoadRoom();
        }

    }
}
