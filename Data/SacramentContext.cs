using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SacramentPlanner.Models;
using Microsoft.EntityFrameworkCore;

namespace SacramentPlanner.Data
{
    public class SacramentContext : DbContext
    {
        public SacramentContext(DbContextOptions<SacramentContext> options) : base(options)
        {
        }

        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Speaker> Speakers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<Speaker>().ToTable("Speaker");     
        }

    }
}
