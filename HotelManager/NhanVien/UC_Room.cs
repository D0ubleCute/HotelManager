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
        public string StaffID;     

        public UC_Room(string idStaff)
        {
            InitializeComponent();
            LoadRoom();

            StaffID = idStaff;
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

        void AddReservation(short roomNum, short accomType,
                                           DateTime checkIn, DateTime checkOut, string idCus, string idStaff)
        {
            bool result = ReservationController.InsertReservation(roomNum, accomType, checkIn, checkOut, idCus, idStaff);

            if (result)
            {
                MessageBox.Show("Tạo đơn đặt phòng thành công", "Thành công");
                LoadRoom();
            }
            else
            {
                MessageBox.Show("Tạo đơn đặt phòng thành công thất bại", "Lỗi");
            }
        }

        void AddNewReservationAfterChange(string idRes, short roomNum, short accomType,
                                           DateTime checkIn, DateTime checkOut, DateTime? checkOutReal, string idCus, string idStaff, decimal oldTotalPrice, string info,
                                           short newRoomNum, short newAccoType, DateTime newCheckIn, DateTime newCheckOutInit)
        {
            Reservation reservation = ReservationController.FindProcessingReservationByRoomNum(roomNum);
            idRes = reservation.idReservation;

            bool result = ReservationController.CloseProcessingReservationAndChangeRoom(idRes, roomNum, accomType, checkIn, checkOut, checkOutReal, oldTotalPrice, info
                                                                                        , newRoomNum, newAccoType, newCheckIn, newCheckOutInit, idCus, idStaff);

            if (result)
            {
                MessageBox.Show("Đổi phòng thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoom();
            }
            else
            {
                MessageBox.Show("Đổi phòng thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CloseProcessingReservation(string idRes, short roomNum, short accomType,
                                           DateTime checkIn, DateTime checkOutInit, DateTime? checkOutREAL, string paymentInfo)
        {
            bool result = ReservationController.CloseProcessingReservation(idRes, roomNum, accomType, checkIn, checkOutInit, checkOutREAL, 0, paymentInfo);

            if (result)
            {
                MessageBox.Show("Đơn đặt phòng thanh toán thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRoom();
            }
            else
            {
                MessageBox.Show("Đơn đặt phòng thanh toán thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Btn_Click(object sender, EventArgs e)
        {
            int roomNum = ((sender as Button).Tag as Room).roomNum;
            showRoomInfo(roomNum);
        }

        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            if (txtRoomNum.Text == null || txtRoomNum.Text.Equals("")) {
                MessageBox.Show("Hãy chọn 1 phòng", "Xác nhận");
                return;
            } else
            {
                Room room = RoomController.loadRoombyRoomNum(Convert.ToInt16(txtRoomNum.Text));
                if (room.isOccupied)
                {
                    MessageBox.Show("Phòng đang được sử dụng, vui lòng chọn phòng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }  else if (!room.isClean)
                {
                    MessageBox.Show("Phòng đang được sửa chữa, vui lòng chọn phòng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }            
            }

            string roomNum = txtRoomNum.Text;
            DialogResult dialogResult = MessageBox.Show("Bạn muốn tạo đơn đặt phòng mới?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var form = new CreateReservation(roomNum))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        short accoType = form.accoType;            //values preserved after close
                        DateTime checkInDate = form.checkInDate;
                        DateTime checkOutDate = form.checkOutDate;
                        string cusPhone = form.cusPhone;

                        Customer cus = CustomerController.GetCustomerByPhone(cusPhone);
                        if (cus == null)
                        {
                            cusPhone = string.Empty;
                        } else
                        {
                            cusPhone = cus.id;
                        }

                        AddReservation(Convert.ToInt16(txtRoomNum.Text), accoType, checkInDate, checkOutDate, cusPhone, StaffID);
                        flowLayoutPanel1.Controls.Clear();
                        LoadRoom();
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (txtRoomNum.Text.Equals("") || txtRoomNum.Text == null)
            {
                MessageBox.Show("Chưa có đơn đặt phòng để thanh toán", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Reservation reservation = ReservationController.FindProcessingReservationByRoomNum(Convert.ToInt16(txtRoomNum.Text));

            if (reservation == null)
            {
                MessageBox.Show("Chưa có đơn đặt phòng để thanh toán", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            CloseProcessingReservation(reservation.idReservation, reservation.roomNum, reservation.accomodationType, reservation.checkinDate,
                                        reservation.checkoutDate, reservation.checkoutDateREAL, "cash");
            Reservation res = ReservationController.GetReservationById(reservation.idReservation);
            Customer cus = CustomerController.GetCustomerById(res.idCustomer);
            flowLayoutPanel1.Controls.Clear();
            LoadRoom();
            INVOICE iNVOICE = new INVOICE(res.idReservation, res.roomNum, cus.fullName, res.totalPrice);
            iNVOICE.ShowDialog();
        }

        private void btnChangeRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNum.Text == null || txtRoomNum.Text.Equals(""))
            {
                MessageBox.Show("Hãy chọn 1 phòng", "Xác nhận");
                return;
            }
            else
            {
                Room room = RoomController.loadRoombyRoomNum(Convert.ToInt16(txtRoomNum.Text));
                if (!room.isClean)
                {
                    MessageBox.Show("Phòng đang được sửa chữa, vui lòng chọn phòng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            string roomNum = txtRoomNum.Text;
            Reservation res = ReservationController.FindProcessingReservationByRoomNum(Convert.ToInt16(txtRoomNum.Text));

            if (res != null)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn đổi phòng?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    using (var form = new CreateReservationForChangingRoom())
                    {
                        var result = form.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            short newRoomNum = form.roomNum;
                            short accoType = form.accoType;            //values preserved after close
                            DateTime checkInDate = form.checkInDate;
                            DateTime checkOutDate = form.checkOutDate;

                            AddNewReservationAfterChange(res.idReservation, res.roomNum, res.accomodationType, res.checkinDate, res.checkoutDate, res.checkoutDateREAL, res.idCustomer, res.idStaff,
                                                               0, "Merged to " + newRoomNum.ToString(), newRoomNum, accoType, checkInDate, checkOutDate);
                            flowLayoutPanel1.Controls.Clear();
                            LoadRoom();
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }
    }
 }

