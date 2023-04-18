using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.Controller;

namespace HotelManager.NhanVien
{
    public partial class UC_Service : UserControl
    {
        public string idReservation;
        public UC_Service()
        {
            InitializeComponent();
            LoadProcessingReservation();
            LoadServiceCategory();
            cbbServiceName.DataSource = null;

            // Set the Minimum, Maximum, and initial Value.
            numUDServiceQty.Value = 0;
            numUDServiceQty.Maximum = 100;
            numUDServiceQty.Minimum = -100;
        }

        void LoadServiceCategory()
        {
            List<RoomExtraCategory> listRoomServiceCategory = ServiceController.GetRoomServiceCategory();
            cbbServiceCategory.DataSource = listRoomServiceCategory;
            cbbServiceCategory.DisplayMember = "nameCategory";
        }

        void LoadServiceName(string id)
        {
            List<RoomExtra> listRoomServiceName = ServiceController.GetRoomServiceByCategory(id);
            cbbServiceName.DataSource = listRoomServiceName;
            cbbServiceName.DisplayMember = "nameService";
        }

        void LoadProcessingReservation()
        {
            dataGVProcessingReservation.DataSource = ReservationController.GetProcessingReservation();
            dataGVProcessingReservation.AllowUserToAddRows = false;
        }

        void LoadServicesByReservationID(string idReservation)
        {
            dataGVBookedServicesByRoom.DataSource = ServiceReservationByRoomController.GetRoomServiceListByReservation(idReservation);
        }

        void InsertServiceInfo(string idService, short roomNum, short serviceQty, string idReservation)
        {
            bool result = ServiceReservationByRoomController.InsertServiceInfo(idService, roomNum, serviceQty, idReservation);

            if (result)
            {
                MessageBox.Show("Thêm dịch vụ vào đơn thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadServicesByReservationID(idReservation);
            }
            else
            {
                MessageBox.Show("Tạo đơn đặt phòng thành công thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbServiceCategory_SelectedValueChanged(object sender, EventArgs e)
        {
                
        }

        private void cbbServiceCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idCategory = "";
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }

            RoomExtraCategory selected = cb.SelectedItem as RoomExtraCategory;
            idCategory += selected.idCategory;
            LoadServiceName(idCategory);
        }

        private void dataGVProcessingReservation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGVProcessingReservation.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                idReservation = dataGVProcessingReservation.Rows[e.RowIndex].Cells[0].Value.ToString();
                dataGVProcessingReservation.Tag = idReservation;
                LoadServicesByReservationID(idReservation);
            }
            else if (e.RowIndex < 0)
            {
                MessageBox.Show("Bấm lung tung thế!", "Thông báo");

            }
        }

        private void btnCreateService_Click(object sender, EventArgs e)
        {        
            if (numUDServiceQty.Value > 100 || numUDServiceQty.Value < -100)
            {
                MessageBox.Show("Số lượng chưa hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            Reservation reservation = ReservationController.GetReservationById(dataGVProcessingReservation.Tag.ToString());

            string idReservation = reservation.idReservation;
            if (idReservation == null)
            {
                MessageBox.Show("Không có thông tin đơn đặt phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            short roomNum = reservation.roomNum;
            string idService = (cbbServiceName.SelectedItem as RoomExtra).idService;
            short serviceQty = Convert.ToInt16(numUDServiceQty.Value);
            if (idReservation != null) 
            {
                InsertServiceInfo(idService, roomNum, serviceQty, idReservation);
            }
            
            //InsertServiceInfo()

        }

        private void dataGVProcessingReservation_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGVProcessingReservation.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGVProcessingReservation.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGVProcessingReservation.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["Mã đặt phòng"].Value);
                dataGVBookedServicesByRoom.DataSource = ServiceReservationByRoomController.GetRoomServiceListByReservation(cellValue);

                CultureInfo culture = new CultureInfo("vi-VN");
                txtServiceTotalPrice.Text = ServiceReservationByRoomController.GetServiceTotalPrice(dataGVBookedServicesByRoom).ToString("c", culture);
            }
        }
    }
}
