using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Core.DTOs
{
    public abstract class BaseDTO
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public long Telefon { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
    }
}
