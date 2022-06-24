using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    public interface IParking
    {
        public void AddCar(Car car);
        public void RemoveCar(string number);
        public void GetCarInfo(Car car);
        public void GetStatisctics();
    }
}
