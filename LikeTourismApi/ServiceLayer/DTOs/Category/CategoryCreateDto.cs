using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Category
{
    public class CategoryCreateDto
    {
        public byte[] Image { get; set; }
        public string Name { get; set; }
    }
    public class CategoryCreateValidator : AbstractValidator<CategoryCreateDto>
    {
        public CategoryCreateValidator()
        {
            RuleFor(m => m.Image).NotEmpty().WithMessage("Pleace add image");
            RuleFor(m => m.Name).NotEmpty().WithMessage("Pleace add description");           
        }
    }
}
