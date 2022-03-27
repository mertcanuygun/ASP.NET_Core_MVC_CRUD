using CountryDB_MVC.Infrastructure.Repositories.Interface;
using CountryDB_MVC.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CountryDB_MVC.Infrastructure.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDBContext _appDbContext;
        protected DbSet<T> table;

        public BaseRepository(AppDBContext appDBContext)
        {
            this._appDbContext = appDBContext;
            table = _appDbContext.Set<T>();
        }

        public void Create(T Entity)
        {
            table.Add(Entity);
            _appDbContext.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> exp)
        {
            return table.FirstOrDefault(exp);
        }

        public List<T> Gets()
        {
            return table.ToList();
        }

        public List<T> Gets(Expression<Func<T, bool>> exp)
        {
            return table.Where(exp).ToList();
        }

        public void Remove(T Entity)
        {
            _appDbContext.Entry<T>(Entity).State = EntityState.Deleted;
            _appDbContext.SaveChanges();
        }

        public void Update(T Entity)
        {
            _appDbContext.Entry<T>(Entity).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }
    }
}
