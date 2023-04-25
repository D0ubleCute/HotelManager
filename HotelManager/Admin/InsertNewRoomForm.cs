using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Windows.Forms;
using HotelManager.Helper;
using HotelManager.Controller;

namespace HotelManager.Admin
{
    public partial class InsertNewRoomForm : Form
    {
        public DialogResult Result { get; set; }

        public InsertNewRoomForm()
        {
            InitializeComponent();

            cbbRoomType.DataSource = new Dictionary<short, string>()
            {
                {1, "Deluxe/Twin"},
                {2, "Superior"},
                {3, "Suite"},
                {4, "Suite 2 giường đôi"},
                {5, "President"}
            }.ToList();
            cbbRoomType.ValueMember = "Key";
            cbbRoomType.DisplayMember = "Value";

            cbbRoomType.SelectedIndex = 0;

            cbbIDRateByType.DataSource = new Dictionary<string, string>()
            {
                {"DLX", "Deluxe/Twin"},
                {"SUPER", "Superior"},
                {"SUT", "Suite"},
                {"SUT-2", "Suite/Double"},
                {"PRESIDENT", "PRESIDENT"}
            }.ToList();
            cbbIDRateByType.ValueMember = "Key";
            cbbIDRateByType.DisplayMember = "Value";

            cbbIDRateByType.SelectedIndex = 0;
        }

        bool InsertRoom(short roomNum, string roomName, string roomImage, short idType, string typeName, string idRateByType, short area)
        {
            Room room = RoomController.loadRoombyRoomNum(roomNum);

            if (room != null)
            {
                MessageBox.Show("Phòng đã tồn tại, vui lòng chọn số khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool result = RoomController.InsertRoom(roomNum, roomName, "", idType, typeName, idRateByType, area);

            if (result)
            {
                MessageBox.Show("Tạo phòng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } else
            {
                MessageBox.Show("Tạo phòng không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btnAddRoomConfirm_Click(object sender, EventArgs e)
        {
            if (!Validation.IsNumeric(txtRoomNum.Text) || !Validation.IsValidRoomNum(Convert.ToInt16(txtRoomNum.Text)))
            {
                MessageBox.Show("Số phòng chưa đúng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Validation.IsNumeric(txtRoomArea.Text) || Convert.ToInt16(txtRoomArea.Text) > 500)
            {
                MessageBox.Show("Diện tích chưa đúng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!Validation.IsNumeric(txtRoomContain.Text) || Convert.ToInt16(txtRoomContain.Text) > 16)
            {
                MessageBox.Show("Số người chưa đúng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cbbRoomType.SelectedIndex != cbbIDRateByType.SelectedIndex)   {
                MessageBox.Show("Loại phòng và định danh tính phí không giống nhau", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            short roomNum = Convert.ToInt16(txtRoomNum.Text);
            string roomName = txtRoomName.Text;
            short roomArea = Convert.ToInt16(txtRoomArea.Text); 
            short roomContain = Convert.ToInt16(txtRoomContain.Text);
            string roomTypeName = txtRoomTypeName.Text;
            short idType = Convert.ToInt16(cbbRoomType.SelectedValue);
            string idRateByType = (cbbIDRateByType.SelectedValue).ToString();

            bool result = InsertRoom(roomNum, roomName, roomTypeName, idType, idRateByType, idRateByType, roomArea);

            if (result)
            {
                DialogResult = DialogResult.OK;

                Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
