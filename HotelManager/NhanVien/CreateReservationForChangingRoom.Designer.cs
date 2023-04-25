namespace HotelManager.NhanVien
{
    partial class CreateReservationForChangingRoom
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
            this.dtpCheckout = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpCheckin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnConfirmCreateRes = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbAccomodation = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbNewRoomNum = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpCheckout
            // 
            this.dtpCheckout.Checked = true;
            this.dtpCheckout.FillColor = System.Drawing.Color.White;
            this.dtpCheckout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCheckout.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckout.Location = new System.Drawing.Point(327, 287);
            this.dtpCheckout.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckout.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckout.Name = "dtpCheckout";
            this.dtpCheckout.Size = new System.Drawing.Size(236, 36);
            this.dtpCheckout.TabIndex = 25;
            this.dtpCheckout.Value = new System.DateTime(2023, 4, 13, 2, 50, 44, 92);
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Checked = true;
            this.dtpCheckin.FillColor = System.Drawing.Color.White;
            this.dtpCheckin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpCheckin.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCheckin.Location = new System.Drawing.Point(327, 218);
            this.dtpCheckin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCheckin.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(236, 36);
            this.dtpCheckin.TabIndex = 24;
            this.dtpCheckin.Value = new System.DateTime(2023, 4, 13, 2, 50, 44, 92);
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
            this.btnConfirmCreateRes.Location = new System.Drawing.Point(83, 379);
            this.btnConfirmCreateRes.Name = "btnConfirmCreateRes";
            this.btnConfirmCreateRes.Size = new System.Drawing.Size(479, 77);
            this.btnConfirmCreateRes.TabIndex = 23;
            this.btnConfirmCreateRes.Text = "Tạo đơn đặt phòng";
            this.btnConfirmCreateRes.Click += new System.EventHandler(this.btnConfirmCreateRes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 30);
            this.label4.TabIndex = 20;
            this.label4.Text = "Giờ check-out";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "Giờ check-in";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Loại hình thuê phòng";
            // 
            // cbbAccomodation
            // 
            this.cbbAccomodation.BackColor = System.Drawing.Color.Gainsboro;
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
            this.cbbAccomodation.Location = new System.Drawing.Point(327, 149);
            this.cbbAccomodation.Name = "cbbAccomodation";
            this.cbbAccomodation.Size = new System.Drawing.Size(236, 36);
            this.cbbAccomodation.TabIndex = 17;
            // 
            // cbbNewRoomNum
            // 
            this.cbbNewRoomNum.BackColor = System.Drawing.Color.Gainsboro;
            this.cbbNewRoomNum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNewRoomNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNewRoomNum.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNewRoomNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNewRoomNum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbNewRoomNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbNewRoomNum.ItemHeight = 30;
            this.cbbNewRoomNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbbNewRoomNum.Location = new System.Drawing.Point(326, 91);
            this.cbbNewRoomNum.Name = "cbbNewRoomNum";
            this.cbbNewRoomNum.Size = new System.Drawing.Size(236, 36);
            this.cbbNewRoomNum.TabIndex = 28;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::HotelManager.Properties.Resources.back;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(567, 3);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(49, 54);
            this.guna2ImageButton1.TabIndex = 27;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Phòng mới";
            // 
            // CreateReservationForChangingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbNewRoomNum);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.dtpCheckout);
            this.Controls.Add(this.dtpCheckin);
            this.Controls.Add(this.btnConfirmCreateRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbbAccomodation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateReservationForChangingRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateReservationForChangingRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckout;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCheckin;
        private Guna.UI2.WinForms.Guna2Button btnConfirmCreateRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbbAccomodation;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNewRoomNum;
        private System.Windows.Forms.Label label1;
    }
}