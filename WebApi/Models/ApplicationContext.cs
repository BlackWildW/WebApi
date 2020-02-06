using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DTO;

namespace WebApi.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<SixteenDaysRootEntity> SixteenDaysRootObjects { get; set; }
        public DbSet<DatumEntity> Datums { get; set; }
        public DbSet<WeatherEntity> Weathers { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> dbContext): base (dbContext)
        {
        }
        
    }
    
}
