using Bayi.Core.Models;
using Bayi.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Repository.Repositories
{
    public class AnaBayiRepository : GenericRepository<AnaBayi>, IAnaBayiRepository
    {
        public AnaBayiRepository(AppDbContext? context) : base(context)
        {
        }

        public async Task<List<AnaBayi>> GetAllAnaBayiWithAltBayi()
        {
            //Eager Loading      
            return await _context.AnaBayiler.Include(x=>x.altBayi).ToListAsync();
        }
    }
}
