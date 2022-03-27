using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryDB_MVC.Infrastructure.EntityTypeConfiguration
{
    public class CountryDetailConfiguration : BaseEntityConfiguration<CountryDetail>
    {
        public override void Configure(EntityTypeBuilder<CountryDetail> builder)
        {
            builder.Property(x => x.Year).IsRequired(true);
            builder.Property(x => x.Population).IsRequired(true);

            builder.HasOne(x=> x.Country)
                .WithMany(x=> x.CountryDetails)
                .HasForeignKey(x=> x.CountryID)
                .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
