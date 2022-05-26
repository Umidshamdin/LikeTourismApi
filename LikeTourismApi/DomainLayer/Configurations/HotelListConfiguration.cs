using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Configurations
{
    public class HotelListConfiguration : IEntityTypeConfiguration<HotelList>
    {
        public void Configure(EntityTypeBuilder<HotelList> builder)
        {
            builder.Property(m => m.Image).IsRequired();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(150);
            builder.Property(m => m.Distance).IsRequired();
            builder.Property(m => m.Desc).HasMaxLength(300);
            builder.Property(m => m.Rating).IsRequired();
            builder.Property(m => m.Prise).IsRequired();
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
        }
    }
}
