namespace HotelManager.NhanVien
{
    partial class CreateReservation
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReservation));
            this.label9 = new System.Windows.Forms.Label();
            this.cbbAccomodation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomerInfo = new System.Windows.Forms.TextBox();
            this.btnConfirmCreateRes = new Guna.UI2.WinForms.Guna2Button();
            this.dtpCheckin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpCheckout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lbRoomNum = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Salmon;
            this.label9.Location = new System.Drawing.Point(231, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 37);
            this.label9.TabIndex = 0;
            this.label9.Text = "Phòng";
            // 
            // cbbAccomodation
            // 
            this.cbbAccomodation.BackColor = System.Drawing.Color.Transparent;
            this.cbbAccomodation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbAccomodation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAccomodation.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbAccomodation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbAccomodation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbAccomodation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbAccomodation.ItemHeight = 30;
            this.cbbAccomodation.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbAccomodation.Location = new System.Drawing.Point(314, 107);
            this.cbbAccomodation.Name = "cbbAccomodation";
            this.cbbAccomodation.Size = new System.Drawing.Size(236, 36);
            this.cbbAccomodation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại hình thuê phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giờ check-in";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giờ check-out";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Khách hàng";
            // 
            // txtCustomerInfo
            // 
            this.txtCustomerInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerInfo.Location = new System.Drawing.Point(314, 321);
            this.txtCustomerInfo.Name = "txtCustomerInfo";
            this.txtCustomerInfo.Size = new System.Drawing.Size(236, 33);
            this.txtCustomerInfo.TabIndex = 9;
            // 
            // btnConfirmCreateRes
            // 
            this.btnConfirmCreateRes.AutoRoundedCorners = true;
            this.btnConfirmCreateRes.BorderRadius = 37;
            this.btnConfirmCreateRes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmCreateRes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmCreateRes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmCreateRes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmCreateRes.FillColor = System.Drawing.Color.Salmon;
            this.btnConfirmCreateRes.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCreateRes.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCreateRes.Location = new System.Drawing.Point(70, 400);
            this.btnConfirmCreateRes.Name = "btnConfirmCreateRes";
            this.btnConfirmCreateRes.Size = new System.Drawing.Size(480, 77);
            this.btnConfirmCreateRes.TabIndex = 11;
            this.btnConfirmCreateRes.Text = "Tạo đơn đặt phòng";
            this.btnConfirmCreateRes.Click += new System.EventHandler(this.btnConfirmCreateRes_Click);
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Checked = true;
            this.dtpCheckin.FillColor = System.Drawing.Color.White;
            this.dtpCheckin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckin.Location = new System.Drawing.Point(314, 176);
            this.dtpCheckin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(236, 36);
            this.dtpCheckin.TabIndex = 12;
            this.dtpCheckin.Value = new System.DateTime(2023, 4, 13, 2, 50, 44, 92);
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.Checked = true;
            this.dtpCheckout.FillColor = System.Drawing.Color.White;
            this.dtpCheckout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckout.Location = new System.Drawing.Point(314, 245);
            this.dtpCheckout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(236, 36);
            this.dtpCheckout.TabIndex = 13;
            this.dtpCheckout.Value = new System.DateTime(2023, 4, 13, 2, 50, 44, 92);
            // 
            // lbRoomNum
            // 
            this.lbRoomNum.AutoSize = true;
            this.lbRoomNum.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomNum.ForeColor = System.Drawing.Color.Salmon;
            this.lbRoomNum.Location = new System.Drawing.Point(326, 47);
            this.lbRoomNum.Name = "lbRoomNum";
            this.lbRoomNum.Size = new System.Drawing.Size(33, 37);
            this.lbRoomNum.TabIndex = 14;
            this.lbRoomNum.Text = "1";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::HotelManager.Properties.Resources.back;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(555, 2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(49, 54);
            this.guna2ImageButton1.TabIndex = 15;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // CreateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 504);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.lbRoomNum);
            this.Controls.Add(this.dtpCheckout);
            this.Controls.Add(this.dtpCheckin);
            this.Controls.Add(this.btnConfirmCreateRes);
            this.Controls.Add(this.txtCustomerInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbAccomodation);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt phòng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cbbAccomodation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomerInfo;
        private Guna.UI2.WinForms.Guna2Button btnConfirmCreateRes;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckin;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckout;
        private System.Windows.Forms.Label lbRoomNum;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}