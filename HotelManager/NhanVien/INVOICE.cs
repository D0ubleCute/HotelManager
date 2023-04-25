using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManager.NhanVien
{
    public partial class INVOICE : Form
    {
        private string idRes;
        private short roomNum;
        private string customerName;
        private decimal totalPrice;
        public INVOICE(string idRes, short roomNum, string cusName, decimal total)
        {
            InitializeComponent();
            this.idRes = idRes;
            this.roomNum = roomNum;
            this.customerName = cusName;
            this.totalPrice = total;

            lbIdRes.Text = idRes;
            lbRoomNum.Text = roomNum.ToString();
            lbTotal.Text = total.ToString();
            lbCus.Text = cusName;
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getPrintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

            PrintDialog pdi = new PrintDialog();
            pdi.Document = printDocument1;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private Bitmap memoryImg;

        private void getPrintArea(Panel pnl)
        {
            memoryImg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg, (pageArea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panel1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
