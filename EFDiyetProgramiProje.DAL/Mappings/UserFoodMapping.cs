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
    internal class UserFoodMapping : IEntityTypeConfiguration<UserFood>
    {
        public void Configure(EntityTypeBuilder<UserFood> builder)
        {
            //Configuring Required Properties
            builder.HasKey(uf => uf.Id);

            builder.Property(uf => uf.CaloriesTaken)
                   .HasColumnType("decimal(18,2)");

            builder.Property(uf => uf.PortionQuantity)
                   .HasColumnType("decimal(18,2)");

            // UserFood - User relationship
            builder.HasOne(uf => uf.User)
                   .WithMany(u => u.UserFoods)
                   .HasForeignKey(uf => uf.UserID)
                  .OnDelete(DeleteBehavior.Restrict);


            // UserFood - Food relationship
            builder.HasOne(uf => uf.Food)
                   .WithMany(f => f.UserFoods)
                   .HasForeignKey(uf => uf.FoodID)
                  .OnDelete(DeleteBehavior.Restrict);


            // UserFood - MealTime relationship
            builder.HasOne(uf => uf.MealTime)
                   .WithMany(mt => mt.UserFoods)
                   .HasForeignKey(uf => uf.MealTimeID)
                   .OnDelete(DeleteBehavior.Restrict);


        }


    }
}
