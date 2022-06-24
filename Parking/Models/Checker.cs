using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Checker : ICheck
    {
        public bool DateTimeChecker(Car car)
        {
            if(car.StartTime < DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CountChecker(Parking parking)
        {
            if(parking.Count + 1 <= parking.Capacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ContainChecker(Parking parking, Car car)
        {
            Car obj = parking.Collection.FirstOrDefault(x => x.Number == car.Number);
            if(!parking.Collection.Contains(obj))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
