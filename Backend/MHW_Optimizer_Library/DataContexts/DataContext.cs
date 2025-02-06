using MHW_Optimizer_Library.Models.Entity;
using MHW_Optimizer_Library.Models.Scaffold;
using Microsoft.EntityFrameworkCore;

namespace MHW_Optimizer_Library.DataContexts
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<BuildProfile> BuildProfiles { get; set; }
        public DbSet<BuildOutput> BuildOutputs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Skill>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<WeaponSharpness>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<WeaponMelody>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<WeaponMelodyNote>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<Quest>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<Monster>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<Charm>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<Weapon>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<WeaponAmmo>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<Tool>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<Item>().Metadata.SetIsTableExcludedFromMigrations(true);
            modelBuilder.Entity<Decoration>().Metadata.SetIsTableExcludedFromMigrations(true);
        }


    }
}
