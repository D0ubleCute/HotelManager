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
            this.dataGVReservation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVReservation)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVReservation
            // 
            this.dataGVReservation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGVReservation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGVReservation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVReservation.GridColor = System.Drawing.Color.Salmon;
            this.dataGVReservation.Location = new System.Drawing.Point(0, 66);
            this.dataGVReservation.Name = "dataGVReservation";
            this.dataGVReservation.Size = new System.Drawing.Size(598, 470);
            this.dataGVReservation.TabIndex = 0;
            this.dataGVReservation.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGVReservation_CellFormatting);
            // 
            // UC_ReservationOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGVReservation);
            this.Name = "UC_ReservationOrder";
            this.Size = new System.Drawing.Size(1166, 536);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVReservation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVReservation;
    }
}
