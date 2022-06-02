using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Reservation
{
    public class ReservationDto
    {

        public int Id { get; set; }
        public string RoomType { get; set; }
        public int RoomPrise { get; set; }
        public string Breakfast { get; set; }

    }
}
