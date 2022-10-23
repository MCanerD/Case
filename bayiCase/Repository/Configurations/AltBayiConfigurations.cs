using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Bayi.Core.Models;

namespace Bayi.Repository.Configurations
{
    public class AltBayiConfigurations : IEntityTypeConfiguration<AltBayi>
    {
        public void Configure(EntityTypeBuilder<AltBayi> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.AltBayiAdi).IsRequired().HasMaxLength(100);
            builder.Property(x => x.AnaBayiId);
            builder.Property(x => x.Mail);
            builder.Property(x => x.Telefon);
            builder.Property(x => x.Il);
            builder.Property(x => x.Ilce);

            builder.ToTable("AltBayiler");

            builder.HasOne(x=>x.AnaBayi).WithMany(x=> x.altBayi).HasForeignKey(x=>x.AnaBayiId); //Bire çok ilişkinin ve foregnkey'in tanımlanması.
        }
    }
}
