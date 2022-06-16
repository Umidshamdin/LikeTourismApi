using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class HotelDescription:BaseEntity
    {
        public string LongDesc { get; set; }
        public string Breakfast { get; set; }
        public string BreakfastType { get; set; }
        public string Parking { get; set; }
        public string Animal { get; set; }
        public string CheckIn { get; set; }

        public int HotelListId { get; set; }
        public HotelList HotelList { get; set; }




    }
}
