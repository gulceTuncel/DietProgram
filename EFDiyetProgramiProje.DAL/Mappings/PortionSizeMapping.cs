using EFDiyetProgramiProje.DATA.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFDiyetProgramiProje.DAL.Mappings
{
    public class PortionSizeMapping : IEntityTypeConfiguration<PortionSize>
    {
        public void Configure(EntityTypeBuilder<PortionSize> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.PortionDescription)
                   .IsRequired()
                   .HasMaxLength(20);
        }
    }
}
