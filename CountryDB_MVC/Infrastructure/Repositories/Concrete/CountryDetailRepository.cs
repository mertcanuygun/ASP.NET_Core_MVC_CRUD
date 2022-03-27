using CountryDB_MVC.Infrastructure.Repositories.Interface;
using CountryDB_MVC.Models.Entities;

namespace CountryDB_MVC.Infrastructure.Repositories.Concrete
{
    public class CountryDetailRepository : BaseRepository<CountryDetail>, ICountryDetailRepository
    {
        public CountryDetailRepository(AppDBContext appDBContext) : base(appDBContext)
        {
        }
    }
}
