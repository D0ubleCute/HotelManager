namespace HotelManager.NhanVien
{
    partial class UC_Room
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnChangeRoom = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateReservation = new Guna.UI2.WinForms.Guna2Button();
            this.btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.tpRoomThings = new System.Windows.Forms.TabPage();
            this.tpRoomInfo = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbRoomFacility = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.txtRoomNum = new System.Windows.Forms.TextBox();
            this.txtRoomType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRoomArea = new System.Windows.Forms.TextBox();
            this.tabControlForFacility = new Guna.UI2.WinForms.Guna2TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.tpRoomInfo.SuspendLayout();
            this.tabControlForFacility.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(528, 476);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.tabControlForFacility);
            this.panel3.Location = new System.Drawing.Point(538, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(625, 389);
            this.panel3.TabIndex = 13;
            // 
            // btnChangeRoom
            // 
            this.btnChangeRoom.AutoRoundedCorners = true;
            this.btnChangeRoom.BorderRadius = 21;
            this.btnChangeRoom.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeRoom.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangeRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangeRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangeRoom.FillColor = System.Drawing.Color.LightCoral;
            this.btnChangeRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeRoom.ForeColor = System.Drawing.Color.White;
            this.btnChangeRoom.Location = new System.Drawing.Point(538, 6);
            this.btnChangeRoom.Name = "btnChangeRoom";
            this.btnChangeRoom.Size = new System.Drawing.Size(318, 45);
            this.btnChangeRoom.TabIndex = 14;
            this.btnChangeRoom.Text = "Đổi phòng";
            // 
            // btnCreateReservation
            // 
            this.btnCreateReservation.AutoRoundedCorners = true;
            this.btnCreateReservation.BorderRadius = 21;
            this.btnCreateReservation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateReservation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateReservation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateReservation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateReservation.FillColor = System.Drawing.Color.LightCoral;
            this.btnCreateReservation.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReservation.ForeColor = System.Drawing.Color.White;
            this.btnCreateReservation.Location = new System.Drawing.Point(862, 6);
            this.btnCreateReservation.Name = "btnCreateReservation";
            this.btnCreateReservation.Size = new System.Drawing.Size(301, 45);
            this.btnCreateReservation.TabIndex = 15;
            this.btnCreateReservation.Text = "Tạo đơn đặt phòng";
            this.btnCreateReservation.Click += new System.EventHandler(this.btnCreateReservation_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoRoundedCorners = true;
            this.btnCheckout.BorderRadius = 39;
            this.btnCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckout.FillColor = System.Drawing.Color.LightCoral;
            this.btnCheckout.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.Location = new System.Drawing.Point(538, 452);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(625, 81);
            this.btnCheckout.TabIndex = 16;
            this.btnCheckout.Text = "Thanh toán";
            // 
            // tpRoomThings
            // 
            this.tpRoomThings.Location = new System.Drawing.Point(4, 39);
            this.tpRoomThings.Name = "tpRoomThings";
            this.tpRoomThings.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoomThings.Size = new System.Drawing.Size(617, 346);
            this.tpRoomThings.TabIndex = 1;
            this.tpRoomThings.Text = "Đồ dùng";
            this.tpRoomThings.UseVisualStyleBackColor = true;
            // 
            // tpRoomInfo
            // 
            this.tpRoomInfo.BackColor = System.Drawing.Color.SeaShell;
            this.tpRoomInfo.Controls.Add(this.txtRoomArea);
            this.tpRoomInfo.Controls.Add(this.txtRoomType);
            this.tpRoomInfo.Controls.Add(this.txtRoomNum);
            this.tpRoomInfo.Controls.Add(this.txtRoomName);
            this.tpRoomInfo.Controls.Add(this.label3);
            this.tpRoomInfo.Controls.Add(this.label4);
            this.tpRoomInfo.Controls.Add(this.lbRoomFacility);
            this.tpRoomInfo.Controls.Add(this.label5);
            this.tpRoomInfo.Controls.Add(this.label7);
            this.tpRoomInfo.Controls.Add(this.label6);
            this.tpRoomInfo.ForeColor = System.Drawing.Color.IndianRed;
            this.tpRoomInfo.Location = new System.Drawing.Point(4, 39);
            this.tpRoomInfo.Name = "tpRoomInfo";
            this.tpRoomInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tpRoomInfo.Size = new System.Drawing.Size(617, 346);
            this.tpRoomInfo.TabIndex = 0;
            this.tpRoomInfo.Text = "Thông tin phòng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Diện tích";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 21);
            this.label7.TabIndex = 27;
            this.label7.Text = "Cơ sở vật chất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Loại phòng";
            // 
            // lbRoomFacility
            // 
            this.lbRoomFacility.AutoSize = true;
            this.lbRoomFacility.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoomFacility.Location = new System.Drawing.Point(21, 289);
            this.lbRoomFacility.Name = "lbRoomFacility";
            this.lbRoomFacility.Size = new System.Drawing.Size(43, 17);
            this.lbRoomFacility.TabIndex = 28;
            this.lbRoomFacility.Text = "label8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tên phòng";
            // 
            // txtRoomName
            // 
            this.txtRoomName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomName.Location = new System.Drawing.Point(118, 85);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(481, 29);
            this.txtRoomName.TabIndex = 29;
            // 
            // txtRoomNum
            // 
            this.txtRoomNum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomNum.Location = new System.Drawing.Point(118, 21);
            this.txtRoomNum.Name = "txtRoomNum";
            this.txtRoomNum.Size = new System.Drawing.Size(481, 29);
            this.txtRoomNum.TabIndex = 23;
            // 
            // txtRoomType
            // 
            this.txtRoomType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomType.Location = new System.Drawing.Point(118, 148);
            this.txtRoomType.Name = "txtRoomType";
            this.txtRoomType.Size = new System.Drawing.Size(481, 29);
            this.txtRoomType.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số phòng";
            // 
            // txtRoomArea
            // 
            this.txtRoomArea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomArea.Location = new System.Drawing.Point(118, 206);
            this.txtRoomArea.Name = "txtRoomArea";
            this.txtRoomArea.Size = new System.Drawing.Size(481, 29);
            this.txtRoomArea.TabIndex = 31;
            // 
            // tabControlForFacility
            // 
            this.tabControlForFacility.Controls.Add(this.tpRoomInfo);
            this.tabControlForFacility.Controls.Add(this.tpRoomThings);
            this.tabControlForFacility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControlForFacility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlForFacility.ItemSize = new System.Drawing.Size(310, 35);
            this.tabControlForFacility.Location = new System.Drawing.Point(0, 0);
            this.tabControlForFacility.Name = "tabControlForFacility";
            this.tabControlForFacility.SelectedIndex = 0;
            this.tabControlForFacility.Size = new System.Drawing.Size(625, 389);
            this.tabControlForFacility.TabButtonHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.tabControlForFacility.TabButtonHoverState.FillColor = System.Drawing.Color.Gainsboro;
            this.tabControlForFacility.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlForFacility.TabButtonHoverState.ForeColor = System.Drawing.Color.LightCoral;
            this.tabControlForFacility.TabButtonHoverState.InnerColor = System.Drawing.Color.Transparent;
            this.tabControlForFacility.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tabControlForFacility.TabButtonIdleState.FillColor = System.Drawing.Color.White;
            this.tabControlForFacility.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tabControlForFacility.TabButtonIdleState.ForeColor = System.Drawing.Color.LightCoral;
            this.tabControlForFacility.TabButtonIdleState.InnerColor = System.Drawing.Color.White;
            this.tabControlForFacility.TabButtonSelectedState.BorderColor = System.Drawing.Color.White;
            this.tabControlForFacility.TabButtonSelectedState.FillColor = System.Drawing.Color.Transparent;
            this.tabControlForFacility.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlForFacility.TabButtonSelectedState.ForeColor = System.Drawing.Color.LightCoral;
            this.tabControlForFacility.TabButtonSelectedState.InnerColor = System.Drawing.Color.Salmon;
            this.tabControlForFacility.TabButtonSize = new System.Drawing.Size(310, 35);
            this.tabControlForFacility.TabIndex = 2;
            this.tabControlForFacility.TabMenuBackColor = System.Drawing.Color.White;
            this.tabControlForFacility.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(171, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 30);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // UC_Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnCreateReservation);
            this.Controls.Add(this.btnChangeRoom);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UC_Room";
            this.Size = new System.Drawing.Size(1166, 536);
            this.panel3.ResumeLayout(false);
            this.tpRoomInfo.ResumeLayout(false);
            this.tpRoomInfo.PerformLayout();
            this.tabControlForFacility.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnChangeRoom;
        private Guna.UI2.WinForms.Guna2Button btnCreateReservation;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2TabControl tabControlForFacility;
        private System.Windows.Forms.TabPage tpRoomInfo;
        private System.Windows.Forms.TextBox txtRoomArea;
        private System.Windows.Forms.TextBox txtRoomType;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbRoomFacility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpRoomThings;
        private System.Windows.Forms.Label label1;
    }
}
