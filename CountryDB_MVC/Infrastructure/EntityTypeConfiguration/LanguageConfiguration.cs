using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryDB_MVC.Infrastructure.EntityTypeConfiguration
{
    public class LanguageConfiguration:BaseEntityConfiguration<Language>
    {
        public override void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.Property(x => x.LanguageName).IsRequired(true);

            base.Configure(builder);
        }
    }
}
