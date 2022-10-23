using Bayi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Core.Repositories
{
    public interface IAnaBayiRepository : IGenericRepository<AnaBayi>
    {
        Task <List<AnaBayi>> GetAllAnaBayiWithAltBayi();

    }
}
