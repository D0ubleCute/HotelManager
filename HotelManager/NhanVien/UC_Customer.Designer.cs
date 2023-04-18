namespace HotelManager.NhanVien
{
    partial class UC_Customer
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
            this.dataGVReceipt = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpReceiptList = new System.Windows.Forms.TabPage();
            this.txtCustomerEm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerPoint = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnUpdateCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.mtxtCustomerDob = new System.Windows.Forms.MaskedTextBox();
            this.txtCustomerPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCustomerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.tpCustomerInfo = new System.Windows.Forms.TabPage();
            this.tabKhachHang = new Guna.UI2.WinForms.Guna2TabControl();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dataGVCustomer = new System.Windows.Forms.DataGridView();
            this.txtCustomerIDNum = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpReceiptList.SuspendLayout();
            this.tpCustomerInfo.SuspendLayout();
            this.tabKhachHang.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVReceipt
            // 
            this.dataGVReceipt.AllowUserToAddRows = false;
            this.dataGVReceipt.AllowUserToDeleteRows = false;
            this.dataGVReceipt.AllowUserToResizeColumns = false;
            this.dataGVReceipt.AllowUserToResizeRows = false;
            this.dataGVReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGVReceipt.BackgroundColor = System.Drawing.Color.LightCoral;
            this.dataGVReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVReceipt.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGVReceipt.Location = new System.Drawing.Point(2, 2);
            this.dataGVReceipt.Name = "dataGVReceipt";
            this.dataGVReceipt.RowHeadersVisible = false;
            this.dataGVReceipt.Size = new System.Drawing.Size(914, 175);
            this.dataGVReceipt.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView2.Location = new System.Drawing.Point(353, 5);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // tpReceiptList
            // 
            this.tpReceiptList.Controls.Add(this.dataGVReceipt);
            this.tpReceiptList.Controls.Add(this.dataGridView2);
            this.tpReceiptList.Location = new System.Drawing.Point(4, 4);
            this.tpReceiptList.Margin = new System.Windows.Forms.Padding(2);
            this.tpReceiptList.Name = "tpReceiptList";
            this.tpReceiptList.Padding = new System.Windows.Forms.Padding(2);
            this.tpReceiptList.Size = new System.Drawing.Size(918, 179);
            this.tpReceiptList.TabIndex = 1;
            this.tpReceiptList.Text = "Đơn đặt phòng";
            this.tpReceiptList.UseVisualStyleBackColor = true;
            // 
            // txtCustomerEm
            // 
            this.txtCustomerEm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerEm.DefaultText = "";
            this.txtCustomerEm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerEm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerEm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerEm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerEm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerEm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerEm.ForeColor = System.Drawing.Color.Blue;
            this.txtCustomerEm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerEm.Location = new System.Drawing.Point(469, 67);
            this.txtCustomerEm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerEm.Name = "txtCustomerEm";
            this.txtCustomerEm.PasswordChar = '\0';
            this.txtCustomerEm.PlaceholderText = "";
            this.txtCustomerEm.SelectedText = "";
            this.txtCustomerEm.Size = new System.Drawing.Size(445, 39);
            this.txtCustomerEm.TabIndex = 11;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerName.DefaultText = "";
            this.txtCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerName.ForeColor = System.Drawing.Color.Blue;
            this.txtCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerName.Location = new System.Drawing.Point(469, 3);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.PlaceholderText = "";
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.Size = new System.Drawing.Size(445, 39);
            this.txtCustomerName.TabIndex = 10;
            // 
            // txtCustomerPoint
            // 
            this.txtCustomerPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerPoint.DefaultText = "";
            this.txtCustomerPoint.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerPoint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerPoint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerPoint.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerPoint.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerPoint.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerPoint.ForeColor = System.Drawing.Color.Blue;
            this.txtCustomerPoint.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerPoint.Location = new System.Drawing.Point(201, 132);
            this.txtCustomerPoint.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerPoint.Name = "txtCustomerPoint";
            this.txtCustomerPoint.PasswordChar = '\0';
            this.txtCustomerPoint.PlaceholderText = "";
            this.txtCustomerPoint.SelectedText = "";
            this.txtCustomerPoint.Size = new System.Drawing.Size(249, 39);
            this.txtCustomerPoint.TabIndex = 9;
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateCustomer.FillColor = System.Drawing.Color.LightCoral;
            this.btnUpdateCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCustomer.ForeColor = System.Drawing.Color.White;
            this.btnUpdateCustomer.Location = new System.Drawing.Point(469, 132);
            this.btnUpdateCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(226, 37);
            this.btnUpdateCustomer.TabIndex = 8;
            this.btnUpdateCustomer.Text = "Sửa thông tin KH";
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCustomer.FillColor = System.Drawing.Color.LightCoral;
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddCustomer.Location = new System.Drawing.Point(699, 132);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(215, 37);
            this.btnAddCustomer.TabIndex = 7;
            this.btnAddCustomer.Text = "Thêm KH mới";
            // 
            // mtxtCustomerDob
            // 
            this.mtxtCustomerDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtCustomerDob.Location = new System.Drawing.Point(5, 134);
            this.mtxtCustomerDob.Margin = new System.Windows.Forms.Padding(2);
            this.mtxtCustomerDob.Mask = "00/00/0000";
            this.mtxtCustomerDob.Name = "mtxtCustomerDob";
            this.mtxtCustomerDob.Size = new System.Drawing.Size(174, 37);
            this.mtxtCustomerDob.TabIndex = 2;
            this.mtxtCustomerDob.ValidatingType = typeof(System.DateTime);
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerPhone.DefaultText = "";
            this.txtCustomerPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerPhone.ForeColor = System.Drawing.Color.Blue;
            this.txtCustomerPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerPhone.Location = new System.Drawing.Point(201, 3);
            this.txtCustomerPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.PasswordChar = '\0';
            this.txtCustomerPhone.PlaceholderText = "";
            this.txtCustomerPhone.SelectedText = "";
            this.txtCustomerPhone.Size = new System.Drawing.Size(249, 39);
            this.txtCustomerPhone.TabIndex = 1;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerID.DefaultText = "";
            this.txtCustomerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerID.ForeColor = System.Drawing.Color.Blue;
            this.txtCustomerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerID.Location = new System.Drawing.Point(5, 3);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.PasswordChar = '\0';
            this.txtCustomerID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtCustomerID.PlaceholderText = "";
            this.txtCustomerID.SelectedText = "";
            this.txtCustomerID.Size = new System.Drawing.Size(174, 39);
            this.txtCustomerID.TabIndex = 0;
            // 
            // tpCustomerInfo
            // 
            this.tpCustomerInfo.Controls.Add(this.txtCustomerIDNum);
            this.tpCustomerInfo.Controls.Add(this.txtCustomerEm);
            this.tpCustomerInfo.Controls.Add(this.txtCustomerName);
            this.tpCustomerInfo.Controls.Add(this.txtCustomerPoint);
            this.tpCustomerInfo.Controls.Add(this.btnUpdateCustomer);
            this.tpCustomerInfo.Controls.Add(this.btnAddCustomer);
            this.tpCustomerInfo.Controls.Add(this.mtxtCustomerDob);
            this.tpCustomerInfo.Controls.Add(this.txtCustomerPhone);
            this.tpCustomerInfo.Controls.Add(this.txtCustomerID);
            this.tpCustomerInfo.Location = new System.Drawing.Point(4, 4);
            this.tpCustomerInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tpCustomerInfo.Name = "tpCustomerInfo";
            this.tpCustomerInfo.Padding = new System.Windows.Forms.Padding(2);
            this.tpCustomerInfo.Size = new System.Drawing.Size(918, 179);
            this.tpCustomerInfo.TabIndex = 0;
            this.tpCustomerInfo.Text = "Thông tin khách hàng";
            this.tpCustomerInfo.UseVisualStyleBackColor = true;
            // 
            // tabKhachHang
            // 
            this.tabKhachHang.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabKhachHang.Controls.Add(this.tpCustomerInfo);
            this.tabKhachHang.Controls.Add(this.tpReceiptList);
            this.tabKhachHang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabKhachHang.ItemSize = new System.Drawing.Size(240, 40);
            this.tabKhachHang.Location = new System.Drawing.Point(0, 349);
            this.tabKhachHang.Margin = new System.Windows.Forms.Padding(2);
            this.tabKhachHang.Name = "tabKhachHang";
            this.tabKhachHang.SelectedIndex = 0;
            this.tabKhachHang.Size = new System.Drawing.Size(1166, 187);
            this.tabKhachHang.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tabKhachHang.TabButtonHoverState.FillColor = System.Drawing.Color.Transparent;
            this.tabKhachHang.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabKhachHang.TabButtonHoverState.ForeColor = System.Drawing.Color.Salmon;
            this.tabKhachHang.TabButtonHoverState.InnerColor = System.Drawing.Color.LightCoral;
            this.tabKhachHang.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabKhachHang.TabButtonIdleState.FillColor = System.Drawing.Color.Transparent;
            this.tabKhachHang.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabKhachHang.TabButtonIdleState.ForeColor = System.Drawing.Color.Salmon;
            this.tabKhachHang.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent;
            this.tabKhachHang.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.tabKhachHang.TabButtonSelectedState.FillColor = System.Drawing.Color.LightCoral;
            this.tabKhachHang.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabKhachHang.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tabKhachHang.TabButtonSelectedState.InnerColor = System.Drawing.Color.Salmon;
            this.tabKhachHang.TabButtonSize = new System.Drawing.Size(240, 40);
            this.tabKhachHang.TabIndex = 4;
            this.tabKhachHang.TabMenuBackColor = System.Drawing.Color.White;
            this.tabKhachHang.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.VerticalRight;
            this.tabKhachHang.Click += new System.EventHandler(this.tabKhachHang_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.guna2Panel1.Controls.Add(this.dataGVCustomer);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1166, 536);
            this.guna2Panel1.TabIndex = 3;
            // 
            // dataGVCustomer
            // 
            this.dataGVCustomer.AllowUserToAddRows = false;
            this.dataGVCustomer.AllowUserToDeleteRows = false;
            this.dataGVCustomer.AllowUserToResizeColumns = false;
            this.dataGVCustomer.AllowUserToResizeRows = false;
            this.dataGVCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVCustomer.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGVCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVCustomer.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGVCustomer.Location = new System.Drawing.Point(0, 0);
            this.dataGVCustomer.Name = "dataGVCustomer";
            this.dataGVCustomer.RowHeadersVisible = false;
            this.dataGVCustomer.Size = new System.Drawing.Size(1166, 536);
            this.dataGVCustomer.TabIndex = 0;
            this.dataGVCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVCustomer_CellClick);
            // 
            // txtCustomerIDNum
            // 
            this.txtCustomerIDNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustomerIDNum.DefaultText = "";
            this.txtCustomerIDNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustomerIDNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustomerIDNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerIDNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustomerIDNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerIDNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerIDNum.ForeColor = System.Drawing.Color.Blue;
            this.txtCustomerIDNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustomerIDNum.Location = new System.Drawing.Point(5, 67);
            this.txtCustomerIDNum.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtCustomerIDNum.Name = "txtCustomerIDNum";
            this.txtCustomerIDNum.PasswordChar = '\0';
            this.txtCustomerIDNum.PlaceholderText = "";
            this.txtCustomerIDNum.SelectedText = "";
            this.txtCustomerIDNum.Size = new System.Drawing.Size(445, 39);
            this.txtCustomerIDNum.TabIndex = 12;
            // 
            // UC_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabKhachHang);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "UC_Customer";
            this.Size = new System.Drawing.Size(1166, 536);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpReceiptList.ResumeLayout(false);
            this.tpCustomerInfo.ResumeLayout(false);
            this.tpCustomerInfo.PerformLayout();
            this.tabKhachHang.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVReceipt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TabPage tpReceiptList;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerEm;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerPoint;
        private Guna.UI2.WinForms.Guna2Button btnUpdateCustomer;
        private Guna.UI2.WinForms.Guna2Button btnAddCustomer;
        private System.Windows.Forms.MaskedTextBox mtxtCustomerDob;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerPhone;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerID;
        private System.Windows.Forms.TabPage tpCustomerInfo;
        private Guna.UI2.WinForms.Guna2TabControl tabKhachHang;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dataGVCustomer;
        private Guna.UI2.WinForms.Guna2TextBox txtCustomerIDNum;
    }
}
