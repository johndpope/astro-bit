﻿using Microsoft.EntityFrameworkCore;

namespace AstroBit.Horizons.DbBuilding
{
    public class EphemerisDbContext : DbContext
    {
        public DbSet<EphemerisDbEntry> Ephemeris { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=Ephemeris.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}