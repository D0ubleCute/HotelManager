namespace HotelManager.Admin
{
    partial class InsertRoomFacility
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
            this.txtNameFacility = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnInsertRoomFacility = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // txtNameFacility
            // 
            this.txtNameFacility.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameFacility.DefaultText = "";
            this.txtNameFacility.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameFacility.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameFacility.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameFacility.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameFacility.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameFacility.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFacility.ForeColor = System.Drawing.Color.LightCoral;
            this.txtNameFacility.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameFacility.Location = new System.Drawing.Point(73, 107);
            this.txtNameFacility.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNameFacility.Name = "txtNameFacility";
            this.txtNameFacility.PasswordChar = '\0';
            this.txtNameFacility.PlaceholderText = "";
            this.txtNameFacility.SelectedText = "";
            this.txtNameFacility.Size = new System.Drawing.Size(396, 50);
            this.txtNameFacility.TabIndex = 2;
            // 
            // btnInsertRoomFacility
            // 
            this.btnInsertRoomFacility.BorderRadius = 10;
            this.btnInsertRoomFacility.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertRoomFacility.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInsertRoomFacility.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInsertRoomFacility.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInsertRoomFacility.FillColor = System.Drawing.Color.LightCoral;
            this.btnInsertRoomFacility.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertRoomFacility.ForeColor = System.Drawing.Color.White;
            this.btnInsertRoomFacility.Location = new System.Drawing.Point(73, 173);
            this.btnInsertRoomFacility.Name = "btnInsertRoomFacility";
            this.btnInsertRoomFacility.Size = new System.Drawing.Size(396, 67);
            this.btnInsertRoomFacility.TabIndex = 3;
            this.btnInsertRoomFacility.Text = "Thêm CSVC";
            this.btnInsertRoomFacility.Click += new System.EventHandler(this.btnInsertRoomFacility_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên CSVC";
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::HotelManager.Properties.Resources.back;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(496, 4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(49, 54);
            this.guna2ImageButton1.TabIndex = 16;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // InsertRoomFacility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 280);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsertRoomFacility);
            this.Controls.Add(this.txtNameFacility);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InsertRoomFacility";
            this.Text = "InsertRoomFacility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox txtNameFacility;
        private Guna.UI2.WinForms.Guna2Button btnInsertRoomFacility;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}