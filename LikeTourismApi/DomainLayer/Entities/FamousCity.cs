using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class FamousCity : BaseEntity
    {
        public string Name { get; set; }
        public byte[] Image { get; set; }

        public List<HotelList> HotelLists { get; set; }

    }
}
