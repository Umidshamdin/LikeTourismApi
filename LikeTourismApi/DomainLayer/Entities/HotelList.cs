using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class HotelList:BaseEntity
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
        public string Desc { get; set; }
        public int Rating { get; set; }
        public int Prise { get; set; }

        public int FamousCityId { get; set; }

        public FamousCity FamousCity { get; set; }


    }
}
