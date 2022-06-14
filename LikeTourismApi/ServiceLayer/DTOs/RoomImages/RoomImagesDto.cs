using ServiceLayer.DTOs.Reservation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.RoomImages
{
    public class RoomImagesDto
    {

        public int Id { get; set; }
        public byte[] Image { get; set; }

        public int ReservationId { get; set; }
     

        public ReservationDto ReservationDto { get; set; }



    }
}
