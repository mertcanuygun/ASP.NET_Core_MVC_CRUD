using CountryDB_MVC.Infrastructure.Repositories.Interface;
using CountryDB_MVC.Models.Entities;

namespace CountryDB_MVC.Infrastructure.Repositories.Concrete
{
    public class Country_LanguageRepository : BaseRepository<Country_Language>, ICountry_LanguageRepository
    {
        public Country_LanguageRepository(AppDBContext appDBContext) : base(appDBContext)
        {
        }
    }
}
