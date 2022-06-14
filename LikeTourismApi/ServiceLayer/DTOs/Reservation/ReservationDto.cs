﻿using ServiceLayer.DTOs.HotelList;
using ServiceLayer.DTOs.RoomImages;
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
        public byte[] Image { get; set; }

        public string RoomType { get; set; }
        public int RoomPrise { get; set; }
        public int Remained { get; set; }
        public List<RoomImagesDto> RoomImages { get; set; }
        public int HotelListId { get; set; }

        public HotelListDto HotelListDto { get; set; }












    }
}
