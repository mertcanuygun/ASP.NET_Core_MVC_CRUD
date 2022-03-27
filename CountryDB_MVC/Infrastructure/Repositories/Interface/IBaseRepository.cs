using CountryDB_MVC.Models.Entities;
using System.Linq.Expressions;

namespace CountryDB_MVC.Infrastructure.Repositories.Interface
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T Entity);
        void Update(T Entity);
        void Remove(T Entity);
        T Get(Expression<Func<T, bool>> exp);
        List<T> Gets();
        List<T> Gets(Expression<Func<T, bool>> exp);
    }
}
