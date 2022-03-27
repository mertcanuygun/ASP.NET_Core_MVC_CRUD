using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryDB_MVC.Infrastructure.SeedData
{
    public class ContinentSeed : IEntityTypeConfiguration<Continent>
    {
        public void Configure(EntityTypeBuilder<Continent> builder)
        {
            builder.HasData(
                new Continent() { Id = 1, ContinentName = "Europe" },
                new Continent() { Id = 2, ContinentName = "Asia" },
                new Continent() { Id = 3, ContinentName = "Africa" },
                new Continent() { Id = 4, ContinentName = "America" },
                new Continent() { Id = 5, ContinentName = "Oceania" });
        }
    }
}
