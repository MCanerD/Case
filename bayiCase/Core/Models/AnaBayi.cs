using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Core.Models
{
    public class AnaBayi : BaseEntity
    {
        public string AnaBayiAdi { get; set; }

        public string? AltBayiAdi { get; set; }

        public ICollection<AltBayi>? altBayi { get; set; }
    }
}
