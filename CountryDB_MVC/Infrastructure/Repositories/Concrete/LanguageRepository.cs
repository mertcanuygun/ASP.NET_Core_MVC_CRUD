using CountryDB_MVC.Infrastructure.Repositories.Interface;
using CountryDB_MVC.Models.Entities;

namespace CountryDB_MVC.Infrastructure.Repositories.Concrete
{
    public class LanguageRepository : BaseRepository<Language>, ILanguageRepository
    {
        public LanguageRepository(AppDBContext appDBContext) : base(appDBContext)
        {
        }
    }
}
