using Bayi.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Repository.Seed
{
    public class AnaBayiSeed : IEntityTypeConfiguration<AnaBayi>
    {
        public void Configure(EntityTypeBuilder<AnaBayi> builder)
        {
            builder.HasData(
                new AnaBayi
                {
                    Id = 1,
                    AnaBayiAdi = "Test Bayi",
                    Mail = "xxx@xxx.xx",
                    Telefon = 2160000,
                    Il = "İstanbul",
                    Ilce = "Kartal",
                    AltBayiAdi = "AltTest",
                });
        }
    }
}
