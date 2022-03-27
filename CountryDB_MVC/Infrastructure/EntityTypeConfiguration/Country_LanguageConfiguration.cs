using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryDB_MVC.Infrastructure.EntityTypeConfiguration
{
    public class Country_LanguageConfiguration:BaseEntityConfiguration<Country_Language>
    {
        public override void Configure(EntityTypeBuilder<Country_Language> builder)
        {
            builder.HasOne(x=> x.Country)
                .WithMany(x=> x.Country_Languages)
                .HasForeignKey(x=>x.CountryID)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Language)
                .WithMany(x => x.Country_Languages)
                .HasForeignKey(x => x.LanguageID)
                .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
