using DBApi.Interfaces;
using DBApi.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace DBApi
{
    public interface IUnitOfWork : IDisposable
    {
        ICarManager CarManager { get; }
        IParkingManager ParkingManager { get; }
        void SaveChanges();

    }
}
