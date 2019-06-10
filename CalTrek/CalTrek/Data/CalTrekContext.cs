using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CalTrekApp.Models;

namespace CalTrek.Models
{
    public class CalTrekContext : DbContext
    {
        public CalTrekContext (DbContextOptions<CalTrekContext> options)
            : base(options)
        {
        }

        public DbSet<CalTrekApp.Models.Obrok> Obrok { get; set; }

        public DbSet<CalTrekApp.Models.Klijent> Klijent { get; set; }

        public DbSet<CalTrekApp.Models.Tjelovjezba> Tjelovjezba { get; set; }

        public DbSet<CalTrekApp.Models.Strucnjak> Strucnjak { get; set; }
    }
}
