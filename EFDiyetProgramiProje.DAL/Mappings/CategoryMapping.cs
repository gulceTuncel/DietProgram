using EFDiyetProgramiProje.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFDiyetProgramiProje.DAL.Mappings
{
    public class CategoryMapping : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CategoryName)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnOrder(2);

            builder.Property(c => c.Description)
                   .HasMaxLength(500)
                   .HasColumnOrder(3);
        }
    }
}