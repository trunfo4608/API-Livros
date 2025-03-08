using LivrosAPP.Service.Data;
using LivrosAPP.Service.Interfaces;

namespace LivrosAPP.Service.Repositories
{
    public class BaseRepository<TEntity> :
        IBaseRepository<TEntity> where TEntity : class
    {
        public void Delete(TEntity entity)
        {
            using (var dataContext = new DataContext()) 
            {
                dataContext.Remove(entity);
                dataContext.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using(var dataContext = new DataContext())
            {
                return dataContext.Set<TEntity>().ToList();
            }
        }
        public void Insert(TEntity entity)
        {
            using(var dataContext = new DataContext())
            {
                dataContext.Add(entity);
                dataContext.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using(var dataContext = new DataContext())
            {
                dataContext.Update(entity);
                dataContext.SaveChanges();
            }
        }
    }
}
