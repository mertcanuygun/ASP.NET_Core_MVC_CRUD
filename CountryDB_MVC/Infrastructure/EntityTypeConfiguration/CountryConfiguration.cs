using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryDB_MVC.Infrastructure.EntityTypeConfiguration
{
    public class CountryConfiguration:BaseEntityConfiguration<Country>
    {
        public override void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(x=> x.CountryName).IsRequired(true);

            builder.HasOne(x=> x.Continent)
                .WithMany(x=> x.Countries)
                .HasForeignKey(x=> x.ContinentID)
                .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
