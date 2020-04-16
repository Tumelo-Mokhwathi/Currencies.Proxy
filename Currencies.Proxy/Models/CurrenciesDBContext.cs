using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Currency.Proxy.Models
{
    public partial class CurrenciesDBContext : DbContext
    {
        public CurrenciesDBContext()
        {
        }

        public CurrenciesDBContext(DbContextOptions<CurrenciesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Currencies> Currencies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=CurrenciesDB;Trusted_Connection=True;MultipleActiveResultSets=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currencies>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.CurrencyName).HasMaxLength(255);

                entity.Property(e => e.CurrencySymbol).HasMaxLength(255);
            });
        }
    }
}
