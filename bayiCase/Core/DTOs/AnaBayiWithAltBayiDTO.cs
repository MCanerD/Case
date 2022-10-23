using Bayi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Core.DTOs
{
    public class AnaBayiWithAltBayiDTO : AnaBayiDTO 
    {
        public AltBayiDTO AltBayi { get; set; }
    }
}
