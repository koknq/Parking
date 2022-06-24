using System;
using System.Collections.Generic;
using System.Text;

namespace Parking
{
    interface ICheck
    {
        public bool DateTimeChecker(Car car);

        public bool CountChecker(Parking parking);

        public bool ContainChecker(Parking parking, Car car);

    }
}
