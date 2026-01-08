using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TstingFrom.Model;

namespace TstingFrom.Data
{
    internal class MangaDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-SIMBA\\SQLEXPRESS; Database = MangaDemo;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Manga> Mangaka  { get; set; }
    }

}
