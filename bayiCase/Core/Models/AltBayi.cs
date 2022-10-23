using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Core.Models
{
    public class AltBayi : BaseEntity
    {
        public string AltBayiAdi { get; set; }
        [ForeignKey("AnaBayi")]
        public int AnaBayiId { get; set; }

        public AnaBayi AnaBayi { get; set; }

    }
}
