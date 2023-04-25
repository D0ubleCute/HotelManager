using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelManager.DAO;

namespace HotelManager.Controller
{
    public class VatTuController
    {
        public static List<VatTu> GetVatTu()
        {
            return VatTuDAO.GetVatTu(); 
        }
    }
}
