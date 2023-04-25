namespace HotelManager.Admin
{
    partial class CreateService
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
            this.radioBtnAlready = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2CustomRadioButton2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbExistingService = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNewServiceID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServiceName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numUDServicePrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnConfirmCreateService = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNameCategory = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCategoryID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDServicePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtnAlready
            // 
            this.radioBtnAlready.CheckedState.BorderColor = System.Drawing.Color.Salmon;
            this.radioBtnAlready.CheckedState.BorderThickness = 0;
            this.radioBtnAlready.CheckedState.FillColor = System.Drawing.Color.LightCoral;
            this.radioBtnAlready.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioBtnAlready.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.radioBtnAlready.Location = new System.Drawing.Point(146, 77);
            this.radioBtnAlready.Name = "radioBtnAlready";
            this.radioBtnAlready.Size = new System.Drawing.Size(20, 20);
            this.radioBtnAlready.TabIndex = 17;
            this.radioBtnAlready.Text = "Có sẵn";
            this.radioBtnAlready.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioBtnAlready.UncheckedState.BorderThickness = 2;
            this.radioBtnAlready.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioBtnAlready.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioBtnAlready.CheckedChanged += new System.EventHandler(this.radioBtnAlready_CheckedChanged);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::HotelManager.Properties.Resources.back;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(585, 14);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(49, 54);
            this.guna2ImageButton1.TabIndex = 16;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2CustomRadioButton2
            // 
            this.guna2CustomRadioButton2.CheckedState.BorderColor = System.Drawing.Color.Salmon;
            this.guna2CustomRadioButton2.CheckedState.BorderThickness = 0;
            this.guna2CustomRadioButton2.CheckedState.FillColor = System.Drawing.Color.LightCoral;
            this.guna2CustomRadioButton2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2CustomRadioButton2.Location = new System.Drawing.Point(413, 77);
            this.guna2CustomRadioButton2.Name = "guna2CustomRadioButton2";
            this.guna2CustomRadioButton2.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomRadioButton2.TabIndex = 18;
            this.guna2CustomRadioButton2.Text = "Tạo mới";
            this.guna2CustomRadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2CustomRadioButton2.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton2.CheckedChanged += new System.EventHandler(this.guna2CustomRadioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(251, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Thêm dịch vụ";
            // 
            // cbbExistingService
            // 
            this.cbbExistingService.BackColor = System.Drawing.Color.Transparent;
            this.cbbExistingService.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbExistingService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbExistingService.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbExistingService.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbExistingService.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbExistingService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbExistingService.ItemHeight = 30;
            this.cbbExistingService.Location = new System.Drawing.Point(244, 121);
            this.cbbExistingService.Name = "cbbExistingService";
            this.cbbExistingService.Size = new System.Drawing.Size(317, 36);
            this.cbbExistingService.TabIndex = 20;
            // 
            // txtNewServiceID
            // 
            this.txtNewServiceID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewServiceID.DefaultText = "";
            this.txtNewServiceID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewServiceID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewServiceID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewServiceID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewServiceID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewServiceID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNewServiceID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNewServiceID.Location = new System.Drawing.Point(244, 365);
            this.txtNewServiceID.Name = "txtNewServiceID";
            this.txtNewServiceID.PasswordChar = '\0';
            this.txtNewServiceID.PlaceholderText = "";
            this.txtNewServiceID.SelectedText = "";
            this.txtNewServiceID.Size = new System.Drawing.Size(317, 36);
            this.txtNewServiceID.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(54, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 30);
            this.label2.TabIndex = 22;
            this.label2.Text = "Loại hình dịch vụ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(54, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 30);
            this.label3.TabIndex = 23;
            this.label3.Text = "Mã dịch vụ mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightCoral;
            this.label4.Location = new System.Drawing.Point(172, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 30);
            this.label4.TabIndex = 24;
            this.label4.Text = "Có sẵn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightCoral;
            this.label5.Location = new System.Drawing.Point(439, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 30);
            this.label5.TabIndex = 25;
            this.label5.Text = "Tạo mới";
            // 
            // txtServiceName
            // 
            this.txtServiceName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceName.DefaultText = "";
            this.txtServiceName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServiceName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServiceName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServiceName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServiceName.Location = new System.Drawing.Point(244, 442);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PasswordChar = '\0';
            this.txtServiceName.PlaceholderText = "";
            this.txtServiceName.SelectedText = "";
            this.txtServiceName.Size = new System.Drawing.Size(317, 36);
            this.txtServiceName.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightCoral;
            this.label6.Location = new System.Drawing.Point(54, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Tên dịch vụ";
            // 
            // numUDServicePrice
            // 
            this.numUDServicePrice.BackColor = System.Drawing.Color.Transparent;
            this.numUDServicePrice.BorderThickness = 2;
            this.numUDServicePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numUDServicePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDServicePrice.Location = new System.Drawing.Point(244, 507);
            this.numUDServicePrice.Maximum = new decimal(new int[] {
            5000000,
            0,
            0,
            0});
            this.numUDServicePrice.Name = "numUDServicePrice";
            this.numUDServicePrice.Size = new System.Drawing.Size(317, 36);
            this.numUDServicePrice.TabIndex = 28;
            this.numUDServicePrice.UpDownButtonFillColor = System.Drawing.Color.LightCoral;
            this.numUDServicePrice.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightCoral;
            this.label7.Location = new System.Drawing.Point(60, 507);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 30);
            this.label7.TabIndex = 29;
            this.label7.Text = "Giá tiền";
            // 
            // btnConfirmCreateService
            // 
            this.btnConfirmCreateService.AutoRoundedCorners = true;
            this.btnConfirmCreateService.BorderRadius = 28;
            this.btnConfirmCreateService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmCreateService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmCreateService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmCreateService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmCreateService.FillColor = System.Drawing.Color.Salmon;
            this.btnConfirmCreateService.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCreateService.ForeColor = System.Drawing.Color.White;
            this.btnConfirmCreateService.Location = new System.Drawing.Point(59, 559);
            this.btnConfirmCreateService.Name = "btnConfirmCreateService";
            this.btnConfirmCreateService.Size = new System.Drawing.Size(502, 58);
            this.btnConfirmCreateService.TabIndex = 30;
            this.btnConfirmCreateService.Text = "Tạo dịch vụ";
            this.btnConfirmCreateService.Click += new System.EventHandler(this.btnConfirmCreateService_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightCoral;
            this.label8.Location = new System.Drawing.Point(54, 290);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 30);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tên loại hình";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameCategory.DefaultText = "";
            this.txtNameCategory.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameCategory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameCategory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameCategory.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNameCategory.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameCategory.Location = new System.Drawing.Point(244, 290);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.PasswordChar = '\0';
            this.txtNameCategory.PlaceholderText = "";
            this.txtNameCategory.SelectedText = "";
            this.txtNameCategory.Size = new System.Drawing.Size(317, 36);
            this.txtNameCategory.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightCoral;
            this.label9.Location = new System.Drawing.Point(54, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 30);
            this.label9.TabIndex = 34;
            this.label9.Text = "Mã loại hình mới";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryID.DefaultText = "";
            this.txtCategoryID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCategoryID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryID.Location = new System.Drawing.Point(244, 209);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.PasswordChar = '\0';
            this.txtCategoryID.PlaceholderText = "";
            this.txtCategoryID.SelectedText = "";
            this.txtCategoryID.Size = new System.Drawing.Size(317, 36);
            this.txtCategoryID.TabIndex = 33;
            // 
            // CreateService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 646);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNameCategory);
            this.Controls.Add(this.btnConfirmCreateService);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numUDServicePrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtServiceName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewServiceID);
            this.Controls.Add(this.cbbExistingService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CustomRadioButton2);
            this.Controls.Add(this.radioBtnAlready);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateService";
            ((System.ComponentModel.ISupportInitialize)(this.numUDServicePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioBtnAlready;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbExistingService;
        private Guna.UI2.WinForms.Guna2TextBox txtNewServiceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtServiceName;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2NumericUpDown numUDServicePrice;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2Button btnConfirmCreateService;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txtNameCategory;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryID;
    }
}