using CountryDB_MVC.Infrastructure.Repositories.Interface;
using CountryDB_MVC.Models.Entities;

namespace CountryDB_MVC.Infrastructure.Repositories.Concrete
{
    public class ContinenRepository : BaseRepository<Continent>, IContinentRepository
    {
        public ContinenRepository(AppDBContext appDBContext) : base(appDBContext)
        {
        }
    }
}
