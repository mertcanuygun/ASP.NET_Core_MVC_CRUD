using CountryDB_MVC.Infrastructure.Repositories.Interface;
using CountryDB_MVC.Models.Entities;

namespace CountryDB_MVC.Infrastructure.Repositories.Concrete
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(AppDBContext appDBContext) : base(appDBContext)
        {
        }
    }
}
