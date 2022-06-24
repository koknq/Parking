using DBApi.Interfaces;
using DBApi.Models;

namespace DBApi.Managers
{
    public class CarManager : RepositoryBase<Car>, ICarManager
    {
        public CarManager(RepositoryContext context):base(context)
        {

        }
    }
}
