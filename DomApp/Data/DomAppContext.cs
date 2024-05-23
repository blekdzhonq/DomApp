using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DomApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DomApp.Data
{
    public class DomAppContext : IdentityDbContext<User>
    {

        public DomAppContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Instrument> Instruments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole
                {
                    Name="Admin",
                    NormalizedName = "ADMIN"
                },
                new IdentityRole
                {
                    Name="User",
                    NormalizedName="USER"
                },

            };

            builder.Entity<IdentityRole>().HasData(roles);


            builder.Entity<Instrument>()
            .HasOne<User>(i => i.user)
            .WithMany(i => i.FavoriteInstruments)
            .HasForeignKey(i => i.UserId);


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }
    }
}