using CountryDB_MVC.Infrastructure.EntityTypeConfiguration;
using CountryDB_MVC.Infrastructure.SeedData;
using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CountryDB_MVC.Infrastructure
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options): base(options){ }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Country_Language> Country_Languages { get; set; }
        public DbSet<Continent> Continents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContinentConfiguration());
            modelBuilder.ApplyConfiguration(new Country_LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new CountryDetailConfiguration());

            modelBuilder.ApplyConfiguration(new ContinentSeed());
            modelBuilder.ApplyConfiguration(new CountrySeed());
            modelBuilder.ApplyConfiguration(new Country_LanguageSeed());
            modelBuilder.ApplyConfiguration(new LanguageSeed());
            modelBuilder.ApplyConfiguration(new CountryDetailSeed());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State == EntityState.Modified || x.State == EntityState.Deleted);

            string computerName = Environment.MachineName;
            DateTime dateTime = DateTime.Now;
            string ip = Utilities.RemoteIP.IpAddress;

            foreach (var item in entries)
            {
                BaseEntity entity = item.Entity as BaseEntity;

                switch (item.State)
                {
                    case EntityState.Deleted:
                        entity.DeleteDate = dateTime;
                        entity.DeletedIpAddress = ip;
                        entity.DeletedMachineName = computerName;
                        break;
                    case EntityState.Modified:
                        entity.UpdateDate = dateTime;
                        entity.UpdatedIpAddress = ip;
                        entity.UpdatedMachineName = computerName;
                        break;
                    case EntityState.Added:
                        entity.CreateDate = dateTime;
                        entity.CreatedIpAddress = ip;
                        entity.CreatedMachineName = computerName;
                        break;
                }
            }            
            return base.SaveChanges();
        }
    }
}
