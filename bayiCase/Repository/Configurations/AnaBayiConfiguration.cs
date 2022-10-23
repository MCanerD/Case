using Bayi.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bayi.Repository.Configurations
{
    public class AnaBayiConfiguration : IEntityTypeConfiguration<AnaBayi>
    {
        public void Configure(EntityTypeBuilder<AnaBayi> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.AnaBayiAdi);
            builder.Property(x => x.Mail);
            builder.Property(x => x.Telefon);
            builder.Property(x => x.Il);
            builder.Property(x => x.Ilce);
            builder.Property(x => x.AltBayiAdi);

            builder.ToTable("AnaBayiler");

        }
    }
}
