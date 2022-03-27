using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CountryDB_MVC.Infrastructure.SeedData
{
    public class LanguageSeed : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.HasData(
                new Language() { Id = 1, LanguageName = "English" },
                new Language() { Id = 2, LanguageName = "Chinese" },
                new Language() { Id = 3, LanguageName = "Turkish" },
                new Language() { Id = 4, LanguageName = "Spanish" },
                new Language() { Id = 5, LanguageName = "Afrikaans" });
        }
    }
}
