﻿using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Configurations
{
    public class HouseRoomImagesConfiguration : IEntityTypeConfiguration<HouseRoomImages>
    {
        public void Configure(EntityTypeBuilder<HouseRoomImages> builder)
        {
            builder.Property(m => m.Image).IsRequired();
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
        }
    }
}
