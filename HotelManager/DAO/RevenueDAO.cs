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
            dt.Columns.Add("Giờ check-in", typeof(DateTime));
            dt.Columns.Add("Giờ check-out", typeof(DateTime));
            //dt.Columns.Add("Thời gian", typeof(TimeSpan));
            dt.Columns.Add("Tổng tiền", typeof(decimal));

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = db.USP_GetReportRevenueByDate(fromDate, toDate);

                foreach (var item in query)
                {
                    dt.Rows.Add(item.roomNum, item.accomodationType, item.checkinDate, item.checkoutDate, item.totalPrice);
                }
            }

            return dt;
        }

        public static DataTable GetRevenueByMonth(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Phòng", typeof(string));
            dt.Columns.Add("Loại hình", typeof(string));
            dt.Columns.Add("Giờ check-in", typeof(DateTime));
            dt.Columns.Add("Giờ check-out", typeof(DateTime));
            //dt.Columns.Add("Thời gian", typeof(TimeSpan));
            dt.Columns.Add("Tổng tiền", typeof(decimal));

            using (HotelDataContext db = new HotelDataContext())
            {
                fromDate = new DateTime(fromDate.Year, fromDate.Month, 1);
                toDate = toDate.AddMonths(1).AddDays(-1);

                DateTime a = fromDate.AddMonths(-1);
                var query = db.USP_GetReportRevenueByDate(fromDate, toDate);

                foreach (var item in query)
                {
                    dt.Rows.Add(item.roomNum, item.accomodationType, item.checkinDate, item.checkoutDate, item.totalPrice);
                }
            }

            return dt;
        }

        public static DataTable GetRevenueByYear(DateTime fromDate, DateTime toDate)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Phòng", typeof(string));
            dt.Columns.Add("Loại hình", typeof(string));
            dt.Columns.Add("Giờ check-in", typeof(DateTime));
            dt.Columns.Add("Giờ check-out", typeof(DateTime));
            //dt.Columns.Add("Thời gian", typeof(TimeSpan));
            dt.Columns.Add("Tổng tiền", typeof(decimal));

            using (HotelDataContext db = new HotelDataContext())
            {
                fromDate = new DateTime(fromDate.Year, 1, 1);
                toDate = new DateTime(toDate.Year, 12, 31);

                var query = db.USP_GetReportRevenueByDate(fromDate, toDate);

                foreach (var item in query)
                {
                    dt.Rows.Add(item.roomNum, item.accomodationType, item.checkinDate, item.checkoutDate, item.totalPrice);
                }
            }

            return dt;
        }
    }
}
