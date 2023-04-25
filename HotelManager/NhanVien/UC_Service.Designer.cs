namespace HotelManager.NhanVien
{
    partial class UC_Service
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbServiceCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCreateService = new Guna.UI2.WinForms.Guna2Button();
            this.txtServiceTotalPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.numUDServiceQty = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cbbServiceName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGVProcessingReservation = new System.Windows.Forms.DataGridView();
            this.dataGVBookedServicesByRoom = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numUDServiceQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProcessingReservation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBookedServicesByRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbServiceCategory
            // 
            this.cbbServiceCategory.BackColor = System.Drawing.Color.Transparent;
            this.cbbServiceCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbServiceCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbServiceCategory.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbServiceCategory.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbServiceCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbServiceCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbServiceCategory.ItemHeight = 30;
            this.cbbServiceCategory.Location = new System.Drawing.Point(537, 3);
            this.cbbServiceCategory.Name = "cbbServiceCategory";
            this.cbbServiceCategory.Size = new System.Drawing.Size(352, 36);
            this.cbbServiceCategory.TabIndex = 2;
            this.cbbServiceCategory.SelectedIndexChanged += new System.EventHandler(this.cbbServiceCategory_SelectedIndexChanged);
            this.cbbServiceCategory.SelectedValueChanged += new System.EventHandler(this.cbbServiceCategory_SelectedValueChanged);
            // 
            // btnCreateService
            // 
            this.btnCreateService.BorderRadius = 20;
            this.btnCreateService.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateService.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateService.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateService.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateService.FillColor = System.Drawing.Color.LightCoral;
            this.btnCreateService.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCreateService.ForeColor = System.Drawing.Color.White;
            this.btnCreateService.Location = new System.Drawing.Point(974, 3);
            this.btnCreateService.Name = "btnCreateService";
            this.btnCreateService.Size = new System.Drawing.Size(189, 78);
            this.btnCreateService.TabIndex = 16;
            this.btnCreateService.Text = "Thêm dịch vụ";
            this.btnCreateService.Click += new System.EventHandler(this.btnCreateService_Click);
            // 
            // txtServiceTotalPrice
            // 
            this.txtServiceTotalPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServiceTotalPrice.DefaultText = "";
            this.txtServiceTotalPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServiceTotalPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServiceTotalPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceTotalPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServiceTotalPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServiceTotalPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServiceTotalPrice.ForeColor = System.Drawing.Color.Salmon;
            this.txtServiceTotalPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServiceTotalPrice.Location = new System.Drawing.Point(537, 481);
            this.txtServiceTotalPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtServiceTotalPrice.Name = "txtServiceTotalPrice";
            this.txtServiceTotalPrice.PasswordChar = '\0';
            this.txtServiceTotalPrice.PlaceholderText = "";
            this.txtServiceTotalPrice.ReadOnly = true;
            this.txtServiceTotalPrice.SelectedText = "";
            this.txtServiceTotalPrice.Size = new System.Drawing.Size(626, 49);
            this.txtServiceTotalPrice.TabIndex = 18;
            // 
            // numUDServiceQty
            // 
            this.numUDServiceQty.BackColor = System.Drawing.Color.Transparent;
            this.numUDServiceQty.BorderThickness = 2;
            this.numUDServiceQty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numUDServiceQty.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDServiceQty.Location = new System.Drawing.Point(895, 24);
            this.numUDServiceQty.Name = "numUDServiceQty";
            this.numUDServiceQty.Size = new System.Drawing.Size(73, 36);
            this.numUDServiceQty.TabIndex = 20;
            this.numUDServiceQty.UpDownButtonFillColor = System.Drawing.Color.LightCoral;
            this.numUDServiceQty.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // cbbServiceName
            // 
            this.cbbServiceName.BackColor = System.Drawing.Color.Transparent;
            this.cbbServiceName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbServiceName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbServiceName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbServiceName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbServiceName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbServiceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbServiceName.ItemHeight = 30;
            this.cbbServiceName.Location = new System.Drawing.Point(537, 46);
            this.cbbServiceName.Name = "cbbServiceName";
            this.cbbServiceName.Size = new System.Drawing.Size(352, 36);
            this.cbbServiceName.TabIndex = 21;
            // 
            // dataGVProcessingReservation
            // 
            this.dataGVProcessingReservation.AllowUserToAddRows = false;
            this.dataGVProcessingReservation.AllowUserToDeleteRows = false;
            this.dataGVProcessingReservation.AllowUserToResizeColumns = false;
            this.dataGVProcessingReservation.AllowUserToResizeRows = false;
            this.dataGVProcessingReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGVProcessingReservation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVProcessingReservation.BackgroundColor = System.Drawing.Color.White;
            this.dataGVProcessingReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVProcessingReservation.Location = new System.Drawing.Point(3, 3);
            this.dataGVProcessingReservation.Name = "dataGVProcessingReservation";
            this.dataGVProcessingReservation.RowHeadersVisible = false;
            this.dataGVProcessingReservation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGVProcessingReservation.Size = new System.Drawing.Size(528, 527);
            this.dataGVProcessingReservation.TabIndex = 31;
            this.dataGVProcessingReservation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVProcessingReservation_CellClick);
            this.dataGVProcessingReservation.SelectionChanged += new System.EventHandler(this.dataGVProcessingReservation_SelectionChanged);
            // 
            // dataGVBookedServicesByRoom
            // 
            this.dataGVBookedServicesByRoom.AllowUserToAddRows = false;
            this.dataGVBookedServicesByRoom.AllowUserToDeleteRows = false;
            this.dataGVBookedServicesByRoom.AllowUserToResizeColumns = false;
            this.dataGVBookedServicesByRoom.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightCoral;
            this.dataGVBookedServicesByRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGVBookedServicesByRoom.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGVBookedServicesByRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGVBookedServicesByRoom.ColumnHeadersHeight = 4;
            this.dataGVBookedServicesByRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGVBookedServicesByRoom.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGVBookedServicesByRoom.GridColor = System.Drawing.Color.LightCoral;
            this.dataGVBookedServicesByRoom.Location = new System.Drawing.Point(538, 89);
            this.dataGVBookedServicesByRoom.Name = "dataGVBookedServicesByRoom";
            this.dataGVBookedServicesByRoom.RowHeadersVisible = false;
            this.dataGVBookedServicesByRoom.Size = new System.Drawing.Size(625, 386);
            this.dataGVBookedServicesByRoom.TabIndex = 32;
            this.dataGVBookedServicesByRoom.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGVBookedServicesByRoom.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGVBookedServicesByRoom.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGVBookedServicesByRoom.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGVBookedServicesByRoom.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGVBookedServicesByRoom.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGVBookedServicesByRoom.ThemeStyle.GridColor = System.Drawing.Color.LightCoral;
            this.dataGVBookedServicesByRoom.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGVBookedServicesByRoom.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGVBookedServicesByRoom.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGVBookedServicesByRoom.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGVBookedServicesByRoom.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGVBookedServicesByRoom.ThemeStyle.HeaderStyle.Height = 4;
            this.dataGVBookedServicesByRoom.ThemeStyle.ReadOnly = false;
            this.dataGVBookedServicesByRoom.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGVBookedServicesByRoom.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGVBookedServicesByRoom.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGVBookedServicesByRoom.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGVBookedServicesByRoom.ThemeStyle.RowsStyle.Height = 22;
            this.dataGVBookedServicesByRoom.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGVBookedServicesByRoom.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // UC_Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGVBookedServicesByRoom);
            this.Controls.Add(this.dataGVProcessingReservation);
            this.Controls.Add(this.cbbServiceName);
            this.Controls.Add(this.numUDServiceQty);
            this.Controls.Add(this.txtServiceTotalPrice);
            this.Controls.Add(this.btnCreateService);
            this.Controls.Add(this.cbbServiceCategory);
            this.Name = "UC_Service";
            this.Size = new System.Drawing.Size(1166, 536);
            ((System.ComponentModel.ISupportInitialize)(this.numUDServiceQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProcessingReservation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVBookedServicesByRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cbbServiceCategory;
        private Guna.UI2.WinForms.Guna2Button btnCreateService;
        private Guna.UI2.WinForms.Guna2TextBox txtServiceTotalPrice;
        private Guna.UI2.WinForms.Guna2NumericUpDown numUDServiceQty;
        private Guna.UI2.WinForms.Guna2ComboBox cbbServiceName;
        private System.Windows.Forms.DataGridView dataGVProcessingReservation;
        private Guna.UI2.WinForms.Guna2DataGridView dataGVBookedServicesByRoom;
    }
}
