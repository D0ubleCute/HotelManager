using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAO
{
    public class RevenueDAO
    {
        public static DataTable GetRevenueByDate(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Phòng", typeof(string));
            dt.Columns.Add("Loại hình", typeof(string));
            //dt.Columns.Add("Thời gian", typeof(TimeSpan));
            dt.Columns.Add("Tổng tiền", typeof(decimal));

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = db.USP_GetReportRevenueByDate(fromDate, toDate);

                foreach (var item in query)
                {
                    dt.Rows.Add(item.roomNum, item.accomodationType, item.totalPrice);
                }
            }

            return dt;
        }
    }
}
