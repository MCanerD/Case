using Bayi.Core.DTOs;
using Bayi.Core.Models;
using Bayi.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Core.Services
{
    public interface IAnaBayiService:IService<AnaBayi>
    {
        Task<CustomResponseDTO<List<AnaBayiWithAltBayiDTO>>> GetAllAnaBayiWithAltBayi();
    }
}
