using EFDiyetProgramiProje.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFDiyetProgramiProje.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFDiyetProgramiProje.DAL.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Configuring Required Properties
            builder.HasKey(u => u.Id);

            builder.Property(u => u.FirstName)
                   .IsRequired(false)
                   .HasMaxLength(50);

            builder.Property(u => u.LastName)
                   .IsRequired(false)
                   .HasMaxLength(50);

            builder.Property(u => u.Password)
                   .IsRequired();

            builder.Property(u => u.Email)
                   .IsRequired()
                   .IsUnicode(false)
                   .HasMaxLength(50);

            builder.Property(u => u.DateOfBirth)
                   .IsRequired(false)
                   .HasColumnType("date");

            builder.Property(u => u.Height)
                   .IsRequired(false)
                   .HasColumnType("decimal(5,2)");

            builder.Property(u => u.Weight)
                   .IsRequired(false)
                   .HasColumnType("decimal(5,2)");

            builder.Property(u => u.GoalWeight)
                   .IsRequired(false)
                   .HasColumnType("decimal(5,2)");

            builder.Property(u => u.Gender)
                   .IsRequired(false);

            builder.Property(u => u.ActivityFrequency)
                   .IsRequired(false);

            builder.Property(u => u.BasalMetabolismCalories)
                   .HasColumnType("decimal(10,2)");

            // User - UserFood relationship
            builder.HasMany(u => u.UserFoods)
                   .WithOne(uf => uf.User)
                   .HasForeignKey(uf => uf.UserID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}