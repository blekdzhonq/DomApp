using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DomApp.Interfaces;
using DomApp.Models.DomainModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DomApp.Data
{
    public class DomAppContext : IdentityDbContext<User>
    {

        private readonly ICsvService _csvService;
        private readonly IMapper _mapper;

        public DomAppContext(DbContextOptions dbContextOptions, ICsvService csvService, IMapper mapper) : base(dbContextOptions)
        {
            _csvService = csvService;
            _mapper = mapper;
        }

        public new DbSet<User> Users { get; set; }
        public DbSet<Instrument> Instruments { get; set; }
        public DbSet<MasterInstrument> MasterInstruments { get; set; }


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
            .HasOne<User>(inst => inst.user)
            .WithMany(user => user.FavoriteInstruments)
            .HasForeignKey(inst => inst.UserId);

            var instrumentsDtos = _csvService.ReadInstrumentsFromCsv("Files/AllInstruments.csv");
            var instruments = _mapper.Map<IEnumerable<MasterInstrument>>(instrumentsDtos);
            builder.Entity<MasterInstrument>().HasData(instrumentsDtos);



        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }
    }
}