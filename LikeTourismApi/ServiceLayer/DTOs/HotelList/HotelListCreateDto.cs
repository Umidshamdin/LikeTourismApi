using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.HotelList
{
    public class HotelListCreateDto
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
        public string Desc { get; set; }
        public int Rating { get; set; }
        public int Prise { get; set; }
    }
    public class HotelListCreateValidator : AbstractValidator<HotelListCreateDto>
    {
        public HotelListCreateValidator()
        {
            RuleFor(m => m.Name).NotEmpty().WithMessage("Pleace add name").MinimumLength(4);
            RuleFor(m => m.Image).NotEmpty().WithMessage("Pleace add image");
            RuleFor(m => m.Distance).NotEmpty().WithMessage("Pleace add distance");
            RuleFor(m => m.Desc).NotEmpty().WithMessage("Pleace add description");
            RuleFor(m => m.Rating).NotEmpty().WithMessage("Pleace add rating");
            RuleFor(m => m.Prise).NotEmpty().WithMessage("Pleace add price");


        }
    }
}
