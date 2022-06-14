using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class HotelListImages:BaseEntity
    {
        public byte[] Image { get; set; }
        public int HotelListId { get; set; }
        public HotelList HotelList { get; set; }


    }
}
