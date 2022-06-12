using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.RoomImages
{
    public class CreateRoomImageDto
    {
        public byte[] Image { get; set; }
        public int ReservationId { get; set; }


    }

    public class RoomImagesCreateValidator : AbstractValidator<CreateRoomImageDto>
    {
        public RoomImagesCreateValidator()
        {
            

            RuleFor(m => m.Image).NotEmpty().WithMessage("Pleace add image");
        }
    }
}
