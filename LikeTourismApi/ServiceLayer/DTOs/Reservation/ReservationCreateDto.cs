using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Reservation
{
    public class ReservationCreateDto
    {
        public string RoomType { get; set; }
        public int RoomPrise { get; set; }
        public string Breakfast { get; set; }
    }
    public class ReservationCreateValidator : AbstractValidator<ReservationCreateDto>
    {
        public ReservationCreateValidator()
        {
            RuleFor(m => m.RoomType).NotEmpty().WithMessage("Pleace add Title").MinimumLength(4);
           

            RuleFor(m => m.RoomPrise).NotEmpty().WithMessage("Pleace add prise");
            RuleFor(m => m.Breakfast).NotEmpty().WithMessage("Pleace add breakfast");

        }
    }
}
