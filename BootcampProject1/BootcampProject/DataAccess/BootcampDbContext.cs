using DataAccess.Configurations;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace DataAccess
{
    public class BootcampDbContext : DbContext
    {
        public BootcampDbContext(DbContextOptions<BootcampDbContext> options)
            : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Bootcamp> Bootcamps { get; set; }
        public DbSet<Blacklist> Blacklists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Config klasöründen gelen Fluent API ayarları burada tanıtılacak
            base.OnModelCreating(modelBuilder);
        }
    }
}
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.ApplyConfiguration(new ApplicationConfiguration());

    base.OnModelCreating(modelBuilder);
}
