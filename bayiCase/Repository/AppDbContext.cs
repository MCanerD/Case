using Bayi.Core.Models;
using Bayi.Repository.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Bayi.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AnaBayi>? AnaBayiler { get; set; }
        public DbSet<AltBayi>? AltBayiler { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AnaBayiConfiguration()); //belirlenen yer için uygulanır.
             modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); //o an çalışılan için uygulanır.
            base.OnModelCreating(modelBuilder);
        }

    }
}
