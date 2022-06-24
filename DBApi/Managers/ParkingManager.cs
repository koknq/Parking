using DBApi.Interfaces;
using DBApi.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBApi.Managers
{
    public class ParkingManager : RepositoryBase<Parking>, IParkingManager
    {
        public ParkingManager(RepositoryContext context):base(context)
        {

        }
    }
}
