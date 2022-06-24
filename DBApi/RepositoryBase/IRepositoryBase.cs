using System.Collections.Generic;

namespace DBApi
{
    public interface IRepositoryBase<T> where T : class
    {
        void Create(T entity);
        void RemoveCar(string number);
        public T FindByNumber(string number);
        IEnumerable<T> GetStatistics();
        int Count();
        int CountAddedCars();
        T GetCarInfo(T entity);
        public IEnumerable<T> GetAll();
        public void Update(T entity);
    }
}
