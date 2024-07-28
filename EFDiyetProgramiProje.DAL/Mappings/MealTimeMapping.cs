using EFDiyetProgramiProje.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDiyetProgramiProje.DAL.Mappings
{
    public class MealTimeMapping : IEntityTypeConfiguration<MealTime>
    {
        public void Configure(EntityTypeBuilder<MealTime> builder)
        {
            //Configuring Required Properties
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Name)
                   .IsRequired()
                   .HasMaxLength(50);
        }
    }
}
