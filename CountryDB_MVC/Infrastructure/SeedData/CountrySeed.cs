using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryDB_MVC.Infrastructure.SeedData
{
    public class CountrySeed : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
                new Country() { Id = 1, CountryName = "Argentina", ContinentID = 4 },
                new Country() { Id = 2, CountryName = "China", ContinentID = 2 },
                new Country() { Id = 3, CountryName = "South Africa", ContinentID = 3 },
                new Country() { Id = 4, CountryName = "New Zealand", ContinentID = 5 },
                new Country() { Id = 5, CountryName = "Spain", ContinentID = 1 });
        }
    }
}
