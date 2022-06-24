using DBApi.Models;
using System.Collections.Generic;
using System.Linq;

namespace DBApi
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private RepositoryContext Context { get; set; }
        public RepositoryBase(RepositoryContext context)
        {
            this.Context = context;
        }

        public void Create(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public void RemoveCar(string number)
        {
            Car obj = Context.Cars.Where(x => x.Number == number).FirstOrDefault();
            Context.Cars.Remove(obj);

        }
 
        public T FindByNumber(string number)
        {
            return Context.Set<T>().Find(number);
        }

        public IEnumerable<T> GetStatistics()
        {
            return Context.Set<T>();
        }

        public int Count()
        {
            return Context.Set<T>().Count();
        }
        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public T GetCarInfo(T entity)
        {
            return Context.Set<T>().Find(entity);
        }
        public void Update(T entity)
        {
            Context.Set<T>().Update(entity);
        }

        public int CountAddedCars()
        {
            return Context.Set<Car>().Where(x => x.Status != "Removed").Count();
        }

    }
}
