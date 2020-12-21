using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using StarsFighters.Data.Models;

namespace StarsFighters.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext()
        {

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<User> User { get; set; }

        public DbSet<ContactForm> ContactForms { get; set; }

        public DbSet<Achievement> Achievements { get; set; }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Statistic> Statistics { get; set; }

        public DbSet<Ship> Ships { get; set; }

        public DbSet<Resource> Resources { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Building> Buildings { get; set; }

        public DbSet<Reward> Rewards { get; set; }

        public DbSet<Quest> Quests { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=StarsFighters;Integrated Security=true");

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<Building>().HasData(new Building {Id = 1, BuildingName = 1, UpgradeTimeFormula = "b*l + 3" }); 
            //builder.Entity<Building>().HasData(new Building {Id = 2, BuildingName = 2, UpgradeTimeFormula = "b*l + 2" }); 
            //builder.Entity<Building>().HasData(new Building {Id = 3, BuildingName = 3, UpgradeTimeFormula = "b*l + 1" });


        }
    }
}
