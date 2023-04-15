namespace HotelManager.NhanVien
{
    partial class UC_Reservation
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpToDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFromDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.tpRoomReservation = new System.Windows.Forms.TabPage();
            this.txtResTotalPrice = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtStaffOrder = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReservationCustomerCheckout = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReservationCustomerCheckin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReservationCustomerCMND = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReservationCustomerPhone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReservationCustomerEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtReservationCustomerName = new System.Windows.Forms.TextBox();
            this.tpRoomService = new System.Windows.Forms.TabPage();
            this.txtServiceTotalPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGVRoomServiceByRes = new System.Windows.Forms.DataGridView();
            this.dataGVReservation = new System.Windows.Forms.DataGridView();
            this.btnReservationSort = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.guna2TabControl1.SuspendLayout();
            this.tpRoomReservation.SuspendLayout();
            this.tpRoomService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRoomServiceByRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpToDate
            // 
            this.dtpToDate.Animated = true;
            this.dtpToDate.AutoRoundedCorners = true;
            this.dtpToDate.BorderRadius = 20;
            this.dtpToDate.Checked = true;
            this.dtpToDate.FillColor = System.Drawing.Color.Salmon;
            this.dtpToDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.dtpToDate.ForeColor = System.Drawing.Color.White;
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpToDate.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.dtpToDate.Location = new System.Drawing.Point(366, 3);
            this.dtpToDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpToDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(238, 43);
            this.dtpToDate.TabIndex = 36;
            this.dtpToDate.Value = new System.DateTime(2023, 4, 11, 0, 48, 46, 705);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Animated = true;
            this.dtpFromDate.AutoRoundedCorners = true;
            this.dtpFromDate.BorderColor = System.Drawing.Color.IndianRed;
            this.dtpFromDate.BorderRadius = 20;
            this.dtpFromDate.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.dtpFromDate.Checked = true;
            this.dtpFromDate.FillColor = System.Drawing.Color.Salmon;
            this.dtpFromDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic);
            this.dtpFromDate.ForeColor = System.Drawing.Color.White;
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFromDate.HoverState.FillColor = System.Drawing.Color.LightCoral;
            this.dtpFromDate.Location = new System.Drawing.Point(43, 3);
            this.dtpFromDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFromDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(258, 43);
            this.dtpFromDate.TabIndex = 35;
            this.dtpFromDate.Value = new System.DateTime(2023, 4, 11, 0, 48, 46, 705);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(307, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "Đến:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(2, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "Từ:";
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Controls.Add(this.tpRoomReservation);
            this.guna2TabControl1.Controls.Add(this.tpRoomService);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(248, 48);
            this.guna2TabControl1.Location = new System.Drawing.Point(662, 9);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(501, 524);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.LightCoral;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.LightCoral;
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.LightCoral;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.Salmon;
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(248, 48);
            this.guna2TabControl1.TabIndex = 32;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.Transparent;
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // tpRoomReservation
            // 
            this.tpRoomReservation.Controls.Add(this.label3);
            this.tpRoomReservation.Controls.Add(this.txtReservationID);
            this.tpRoomReservation.Controls.Add(this.txtResTotalPrice);
            this.tpRoomReservation.Controls.Add(this.label15);
            this.tpRoomReservation.Controls.Add(this.txtStaffOrder);
            this.tpRoomReservation.Controls.Add(this.label);
            this.tpRoomReservation.Controls.Add(this.label13);
            this.tpRoomReservation.Controls.Add(this.txtReservationCustomerCheckout);
            this.tpRoomReservation.Controls.Add(this.label12);
            this.tpRoomReservation.Controls.Add(this.txtReservationCustomerCheckin);
            this.tpRoomReservation.Controls.Add(this.label11);
            this.tpRoomReservation.Controls.Add(this.txtReservationCustomerCMND);
            this.tpRoomReservation.Controls.Add(this.label10);
            this.tpRoomReservation.Controls.Add(this.txtReservationCustomerPhone);
            this.tpRoomReservation.Controls.Add(this.label9);
            this.tpRoomReservation.Controls.Add(this.txtReservationCustomerEmail);
            this.tpRoomReservation.Controls.Add(this.label8);
            this.tpRoomReservation.Controls.Add(this.txtReservationCustomerName);
            this.tpRoomReservation.Location = new System.Drawing.Point(4, 52);
            this.tpRoomReservation.Name = "tpRoomReservation";
            this.tpRoomReservation.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoomReservation.Size = new System.Drawing.Size(493, 468);
            this.tpRoomReservation.TabIndex = 0;
            this.tpRoomReservation.Text = "Đặt phòng";
            this.tpRoomReservation.UseVisualStyleBackColor = true;
            // 
            // txtResTotalPrice
            // 
            this.txtResTotalPrice.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResTotalPrice.Location = new System.Drawing.Point(152, 418);
            this.txtResTotalPrice.Name = "txtResTotalPrice";
            this.txtResTotalPrice.Size = new System.Drawing.Size(326, 35);
            this.txtResTotalPrice.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Salmon;
            this.label15.Location = new System.Drawing.Point(19, 421);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 30);
            this.label15.TabIndex = 39;
            this.label15.Text = "Tổng tiền:";
            // 
            // txtStaffOrder
            // 
            this.txtStaffOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffOrder.Location = new System.Drawing.Point(152, 354);
            this.txtStaffOrder.Name = "txtStaffOrder";
            this.txtStaffOrder.Size = new System.Drawing.Size(326, 29);
            this.txtStaffOrder.TabIndex = 38;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(17, 354);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 25);
            this.label.TabIndex = 37;
            this.label.Text = "Nhân viên:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(19, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 25);
            this.label13.TabIndex = 36;
            this.label13.Text = "Check-out: ";
            // 
            // txtReservationCustomerCheckout
            // 
            this.txtReservationCustomerCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationCustomerCheckout.Location = new System.Drawing.Point(152, 303);
            this.txtReservationCustomerCheckout.Name = "txtReservationCustomerCheckout";
            this.txtReservationCustomerCheckout.Size = new System.Drawing.Size(326, 29);
            this.txtReservationCustomerCheckout.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 268);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 25);
            this.label12.TabIndex = 34;
            this.label12.Text = "Check-in: ";
            // 
            // txtReservationCustomerCheckin
            // 
            this.txtReservationCustomerCheckin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationCustomerCheckin.Location = new System.Drawing.Point(152, 268);
            this.txtReservationCustomerCheckin.Name = "txtReservationCustomerCheckin";
            this.txtReservationCustomerCheckin.Size = new System.Drawing.Size(326, 29);
            this.txtReservationCustomerCheckin.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(49, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "CMND: ";
            // 
            // txtReservationCustomerCMND
            // 
            this.txtReservationCustomerCMND.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationCustomerCMND.Location = new System.Drawing.Point(152, 213);
            this.txtReservationCustomerCMND.Name = "txtReservationCustomerCMND";
            this.txtReservationCustomerCMND.Size = new System.Drawing.Size(326, 29);
            this.txtReservationCustomerCMND.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(72, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "SĐT: ";
            // 
            // txtReservationCustomerPhone
            // 
            this.txtReservationCustomerPhone.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationCustomerPhone.Location = new System.Drawing.Point(152, 159);
            this.txtReservationCustomerPhone.Name = "txtReservationCustomerPhone";
            this.txtReservationCustomerPhone.Size = new System.Drawing.Size(326, 29);
            this.txtReservationCustomerPhone.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Email KH: ";
            // 
            // txtReservationCustomerEmail
            // 
            this.txtReservationCustomerEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationCustomerEmail.Location = new System.Drawing.Point(152, 108);
            this.txtReservationCustomerEmail.Name = "txtReservationCustomerEmail";
            this.txtReservationCustomerEmail.Size = new System.Drawing.Size(326, 29);
            this.txtReservationCustomerEmail.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "Họ tên KH: ";
            // 
            // txtReservationCustomerName
            // 
            this.txtReservationCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationCustomerName.Location = new System.Drawing.Point(152, 57);
            this.txtReservationCustomerName.Name = "txtReservationCustomerName";
            this.txtReservationCustomerName.Size = new System.Drawing.Size(326, 29);
            this.txtReservationCustomerName.TabIndex = 25;
            // 
            // tpRoomService
            // 
            this.tpRoomService.Controls.Add(this.txtServiceTotalPrice);
            this.tpRoomService.Controls.Add(this.label1);
            this.tpRoomService.Controls.Add(this.dataGridView1);
            this.tpRoomService.Controls.Add(this.dataGVRoomServiceByRes);
            this.tpRoomService.Location = new System.Drawing.Point(4, 52);
            this.tpRoomService.Name = "tpRoomService";
            this.tpRoomService.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoomService.Size = new System.Drawing.Size(493, 468);
            this.tpRoomService.TabIndex = 1;
            this.tpRoomService.Text = "Đặt dịch vụ";
            this.tpRoomService.UseVisualStyleBackColor = true;
            // 
            // txtServiceTotalPrice
            // 
            this.txtServiceTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceTotalPrice.Location = new System.Drawing.Point(213, 399);
            this.txtServiceTotalPrice.Name = "txtServiceTotalPrice";
            this.txtServiceTotalPrice.Size = new System.Drawing.Size(256, 35);
            this.txtServiceTotalPrice.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(17, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng tiền dịch vụ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(481, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGVRoomServiceByRes
            // 
            this.dataGVRoomServiceByRes.AllowUserToAddRows = false;
            this.dataGVRoomServiceByRes.AllowUserToDeleteRows = false;
            this.dataGVRoomServiceByRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGVRoomServiceByRes.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGVRoomServiceByRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVRoomServiceByRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVRoomServiceByRes.Location = new System.Drawing.Point(3, 3);
            this.dataGVRoomServiceByRes.Name = "dataGVRoomServiceByRes";
            this.dataGVRoomServiceByRes.RowHeadersVisible = false;
            this.dataGVRoomServiceByRes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGVRoomServiceByRes.Size = new System.Drawing.Size(487, 462);
            this.dataGVRoomServiceByRes.TabIndex = 0;
            // 
            // dataGVReservation
            // 
            this.dataGVReservation.AllowUserToAddRows = false;
            this.dataGVReservation.AllowUserToDeleteRows = false;
            this.dataGVReservation.AllowUserToResizeColumns = false;
            this.dataGVReservation.AllowUserToResizeRows = false;
            this.dataGVReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGVReservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVReservation.Location = new System.Drawing.Point(1, 52);
            this.dataGVReservation.Name = "dataGVReservation";
            this.dataGVReservation.RowHeadersVisible = false;
            this.dataGVReservation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGVReservation.Size = new System.Drawing.Size(655, 481);
            this.dataGVReservation.TabIndex = 30;
            this.dataGVReservation.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGVReservation_CellFormatting);
            this.dataGVReservation.SelectionChanged += new System.EventHandler(this.dataGVReservation_SelectionChanged_1);
            // 
            // btnReservationSort
            // 
            this.btnReservationSort.BackColor = System.Drawing.Color.White;
            this.btnReservationSort.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservationSort.Image = global::HotelManager.Properties.Resources.search;
            this.btnReservationSort.Location = new System.Drawing.Point(610, 3);
            this.btnReservationSort.Name = "btnReservationSort";
            this.btnReservationSort.Size = new System.Drawing.Size(46, 43);
            this.btnReservationSort.TabIndex = 31;
            this.btnReservationSort.UseVisualStyleBackColor = false;
            this.btnReservationSort.Click += new System.EventHandler(this.btnReservationSort_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 42;
            this.label3.Text = "Mã đặt phòng: ";
            // 
            // txtReservationID
            // 
            this.txtReservationID.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationID.Location = new System.Drawing.Point(152, 12);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(326, 29);
            this.txtReservationID.TabIndex = 41;
            // 
            // UC_Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.guna2TabControl1);
            this.Controls.Add(this.dataGVReservation);
            this.Controls.Add(this.btnReservationSort);
            this.Name = "UC_Reservation";
            this.Size = new System.Drawing.Size(1166, 536);
            this.guna2TabControl1.ResumeLayout(false);
            this.tpRoomReservation.ResumeLayout(false);
            this.tpRoomReservation.PerformLayout();
            this.tpRoomService.ResumeLayout(false);
            this.tpRoomService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVRoomServiceByRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVReservation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker dtpToDate;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage tpRoomReservation;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtStaffOrder;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtReservationCustomerCheckout;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtReservationCustomerCheckin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtReservationCustomerCMND;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReservationCustomerPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReservationCustomerEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtReservationCustomerName;
        private System.Windows.Forms.TabPage tpRoomService;
        private System.Windows.Forms.DataGridView dataGVRoomServiceByRes;
        private System.Windows.Forms.DataGridView dataGVReservation;
        private System.Windows.Forms.Button btnReservationSort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtServiceTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResTotalPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReservationID;
    }
}
