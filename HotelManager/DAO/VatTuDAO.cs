using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.DAO
{
    public class VatTuDAO
    {
        public static List<VatTu> GetVatTu()
        {
            List<VatTu> things = new List<VatTu>();

            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from room in db.VatTus
                            select room;
                foreach (var item in query)
                {
                    things.Add(item);
                }
            }
            return things;
        }

        public static VatTu GetVatTu(string id) {
            using (HotelDataContext db = new HotelDataContext())
            {
                var query = from room in db.VatTus
                            where room.idVatTu.Equals(id)
                            select room;
               
                if (query != null)
                {
                    return query.FirstOrDefault();
                }
                return null;
            }
        }
    }
}
