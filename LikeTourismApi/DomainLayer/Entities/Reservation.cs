using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Reservation:BaseEntity
    {

        public byte[] Image { get; set; }
        public string RoomType { get; set; }
        public int RoomPrise { get; set; }
        public int Remained { get; set; }
        public List<RoomImages> RoomImages { get; set; }
        public int HotelListId { get; set; }

        public HotelList HotelList { get; set; }





    }
}
