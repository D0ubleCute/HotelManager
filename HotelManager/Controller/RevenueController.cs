using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManager.DAO;

namespace HotelManager.Controller
{
    public class RevenueController
    {
        public static DataTable GetRevenueByDate(DateTime fromDate, DateTime toDate)
        {
            return RevenueDAO.GetRevenueByDate(fromDate, toDate);
        }

        public static decimal GetTotalRevenue(DataGridView dtgvRevenue)
        {
            decimal sum = 0;

            foreach (DataGridViewRow row in dtgvRevenue.Rows)
            {
                sum += Convert.ToDecimal(row.Cells["Tổng tiền"].Value);
            }
            return sum;
        }
    }
}
