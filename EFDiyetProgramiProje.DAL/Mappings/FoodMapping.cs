using EFDiyetProgramiProje.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace EFDiyetProgramiProje.DAL.Mappings
{
    public class FoodMapping : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(f => f.Id);

            builder.Property(f => f.Name)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(f => f.Description)
                   .HasMaxLength(500);

            builder.Property(f => f.Fats)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(f => f.Proteins)
                .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(f => f.Carbs)
                   .HasColumnType("decimal(18,2)")
                   .IsRequired();

            builder.Property(f => f.Calories)
                   .HasColumnType("decimal(18, 2)")
                   .HasComputedColumnSql("(Fats * 9) + ((Proteins + Carbs) * 4)")
                   .IsRequired();

            builder.Property(f => f.Picture)
                   .HasColumnType("varbinary(max)");

            builder.Property(f => f.PortionID)
                   .IsRequired();

            builder.Property(f => f.CategoryID)
                   .IsRequired();

            builder.HasOne(f => f.Category)
              .WithMany(c => c.Foods)
              .HasForeignKey(f => f.CategoryID)
              .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(f => f.Portion)
              .WithMany(p => p.Foods)
              .HasForeignKey(f => f.PortionID)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
