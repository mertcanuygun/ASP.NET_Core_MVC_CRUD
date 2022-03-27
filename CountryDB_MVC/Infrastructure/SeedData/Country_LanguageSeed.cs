using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryDB_MVC.Infrastructure.SeedData
{
    public class Country_LanguageSeed : IEntityTypeConfiguration<Country_Language>
    {
        public void Configure(EntityTypeBuilder<Country_Language> builder)
        {
            builder.HasData(
                new Country_Language() { Id = 1, CountryID = 5, LanguageID = 4 },
                new Country_Language() { Id = 2, CountryID = 2, LanguageID = 2 },
                new Country_Language() { Id = 3, CountryID = 4, LanguageID = 1 },
                new Country_Language() { Id = 4, CountryID = 3, LanguageID = 5 });
        }
    }
}
