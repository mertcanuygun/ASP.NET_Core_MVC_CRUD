using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryDB_MVC.Infrastructure.SeedData
{
    public class CountryDetailSeed : IEntityTypeConfiguration<CountryDetail>
    {
        public void Configure(EntityTypeBuilder<CountryDetail> builder)
        {
            builder.HasData(
                new CountryDetail() { Id = 1, CountryID = 5, Population = 46580000, Year = 2010 },
                new CountryDetail() { Id = 2, CountryID = 5, Population = 40570000, Year = 2000 },
                new CountryDetail() { Id = 3, CountryID = 4, Population = 4350000, Year = 2010 },
                new CountryDetail() { Id = 4, CountryID = 4, Population = 3858000, Year = 2000 },
                new CountryDetail() { Id = 5, CountryID = 4, Population = 3330000, Year = 1990 },
                new CountryDetail() { Id = 6, CountryID = 1, Population = 40790000, Year = 2010 });
        }
    }
}
