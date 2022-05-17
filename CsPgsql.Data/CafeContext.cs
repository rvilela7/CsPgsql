using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CsPgsql.Data
{
    public class CafeContext : DbContext
    {
        public DbSet<Cafe> Cafes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost:5432;Database=Cafe;Username=ruivilela;Password=pwd"); // Todo: upd pwd
    }

    public class Cafe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}