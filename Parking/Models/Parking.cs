using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Parking
{
    public class Parking : IParking
    {
        public Parking(int capacity)
        {
            Collection = new List<Car>();
            Capacity = capacity;
        }

        public List<Car> Collection;
        [Key]
        public int Id { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Number { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Cost { get; set; }
        public int Count => Collection.Count();
        public int Capacity { get; set; }
        public string Status { get; set; }
        public void AddCar(Car car)
        {
            Checker checker = new Checker();
            if (!checker.DateTimeChecker(car))
            {
                Console.WriteLine("Invalid DateTime !");
                return;
            }
            if (!checker.CountChecker(this))
            {
                Console.WriteLine("The parking is full !");
                return;
            }
            if (checker.ContainChecker(this, car))
            {
                Collection.Add(car);
                Console.WriteLine($"Successfully added car: {car.Number} at {car.StartTime}");
            }
            else
            {
                Console.WriteLine("Invalid number of a car !");
            }
        }

        public void RemoveCar(string number)
        {
            Car car = Collection.Where(x => x.Number == number).FirstOrDefault();
            if (Collection.Contains(car))
            {
                Collection.Remove(car);
                Console.WriteLine($"Successfully removed car: {car.Number} ! Cost: {car.Price}lv.");
            }
            else
            {
                Console.WriteLine($"Car with number doesn't exist !");
            }
        }

        public void GetCarInfo(Car car)
        {
            Console.WriteLine(car.ToString());
        }

        public void GetStatisctics()
        {
            if (this.Collection.Count > 0)
            {
                foreach (var car in Collection)
                {
                    Console.WriteLine(car);
                }
                Console.WriteLine($"Full spots: {Collection.Count}/{Capacity}\nFree spots: {Capacity - Collection.Count}/{Capacity}");
            }
            else
            {
                Console.WriteLine("The parking is empty !");
            }
        }


    }
}
