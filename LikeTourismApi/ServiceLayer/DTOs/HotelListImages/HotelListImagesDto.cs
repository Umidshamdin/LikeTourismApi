using ServiceLayer.DTOs.HotelList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.HotelListImages
{
    public class HotelListImagesDto
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public int HotelListId { get; set; }
        public HotelListDto HotelListDto { get; set; }

    }
}
