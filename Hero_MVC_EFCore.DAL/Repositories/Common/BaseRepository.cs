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

        public List<T> GetAll()
        {
            try
            {
                return _dbContext.Set<T>().ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public T? GetById(int id)
        {
            try
            {
                var keyValue = new object[] { id };
                var entity = _dbContext.Set<T>().Find(keyValue);

                if (entity is null)
                    return null;

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Insert(T entity)
        {
            try
            {
                _dbContext.Set<T>().AddAsync(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(T entity)
        {
            try
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                var keyValue = new object[] { id };
                var entity = _dbContext.Set<T>().Find(keyValue);

                if (entity is null)
                    return;

                _dbContext.Set<T>().Remove(entity);
                _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
