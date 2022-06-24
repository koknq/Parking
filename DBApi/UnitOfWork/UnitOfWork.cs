using DBApi.Interfaces;
using DBApi.Managers;
using DBApi.Models;
using System;
using System.Collections.Generic;

namespace DBApi
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RepositoryContext context;
        public ICarManager CarManager { get; }
        public IParkingManager ParkingManager { get; }

        public UnitOfWork(RepositoryContext context)
        {
            this.context = context;
            CarManager = new CarManager(context);
            ParkingManager = new ParkingManager(context);
        }
        
        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
