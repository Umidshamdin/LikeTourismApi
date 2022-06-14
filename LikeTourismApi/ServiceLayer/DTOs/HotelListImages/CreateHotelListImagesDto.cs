using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.HotelListImages
{
    public class CreateHotelListImagesDto
    {
        public byte[] Image { get; set; }
        public int HotelListId { get; set; }

    }

    public class HotelListImagesCreateValidator : AbstractValidator<CreateHotelListImagesDto>
    {
        public HotelListImagesCreateValidator()
        {


            RuleFor(m => m.Image).NotEmpty().WithMessage("Pleace add image");
        }
    }
}
