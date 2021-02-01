using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace RoomService.Models
{
    public class ServiceContext : DbContext
    {
        public ServiceContext() : base()
        {
        }
        public ServiceContext(DbContextOptions<ServiceContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = room.db;");
        }
        public DbSet<Service> Services { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().HasData(
            new Service() { Id = 1, SiteName = "SiteConstructor.io", Description="Description1", PromoCode="PromoCode1", IsBonusActivated = false },
            new Service() { Id = 2, SiteName = "AppVision.io", Description = "Description2", PromoCode = "PromoCode2", IsBonusActivated = false }
            );
        }
    }
}
