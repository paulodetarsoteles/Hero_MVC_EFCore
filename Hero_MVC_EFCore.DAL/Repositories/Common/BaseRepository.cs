using Hero_MVC_EFCore.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace Hero_MVC_EFCore.DAL.Repositories.Common
{
    public class BaseRepository<T> where T : class
    {
        public readonly DataContext _dbContext;

        public BaseRepository(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T? GetById(int id)
        {
            var keyValue = new object[] { id };
            var entity = _dbContext.Set<T>().Find(keyValue);

            if (entity is null)
                return null;

            return entity;
        }

        public void Insert(T entity)
        {
            _dbContext.Set<T>().AddAsync(entity);
            _dbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = GetById(id);

            if (entity is null)
                return;

            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }
    }
}
