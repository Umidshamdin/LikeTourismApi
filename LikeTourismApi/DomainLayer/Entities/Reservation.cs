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
        public string RoomType { get; set; }
        public int RoomPrise { get; set; }
        public string Breakfast { get; set; }
    }
}
