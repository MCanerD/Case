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
    public class Sub_DealerSeed : IEntityTypeConfiguration<AltBayi>
    {
        public void Configure(EntityTypeBuilder<AltBayi> builder)
        {
            builder.HasData(
                new AltBayi
                {
                    Id = 1,
                    AltBayiAdi = "AltTest",
                    AnaBayiId = 1,
                    Mail = "xxx@xx.x",
                    Telefon = 21424,
                    Il = "İstanbul",
                    Ilce = "Maltepe",

                });
        }
    }
}
