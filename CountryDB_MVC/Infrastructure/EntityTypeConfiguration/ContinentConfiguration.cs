using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryDB_MVC.Infrastructure.EntityTypeConfiguration
{
    public class ContinentConfiguration:BaseEntityConfiguration<Continent>
    {
        public override void Configure(EntityTypeBuilder<Continent> builder)
        {
            builder.Property(x=> x.ContinentName).IsRequired(true);

            base.Configure(builder);
        }
    }
}
