using DBApi;
using System;
using System.Linq;

namespace Parking
{
    class StartUp
    {
        static DBApi.Models.Parking parking;
        static void Main(string[] args)
        {

            DbContextFactory dbContextFactory = new DbContextFactory();
            IUnitOfWork unitOfWork = new UnitOfWork(dbContextFactory.CreateDbContext(null));
            int countOfCarsInCarManager = unitOfWork.CarManager.CountAddedCars();

            var getParking = unitOfWork.ParkingManager.GetAll().FirstOrDefault();
            if (getParking == null)
            {
                parking = new DBApi.Models.Parking(100);
                unitOfWork.ParkingManager.Create(parking);
            }
            else
                parking = getParking;

            unitOfWork.SaveChanges();



            DBApi.Models.Car car = new DBApi.Models.Car("Renault Clio", "Yellow", "B6601KH", new DateTime(2022, 06, 21, 07, 01, 49), parking.Id);
            DBApi.Models.Car car2 = new DBApi.Models.Car("Mitsubishi Colt", "White", "B7402BP", new DateTime(2022, 06, 21, 08, 33, 14), parking.Id);
            DBApi.Models.Car car3 = new DBApi.Models.Car("Peugeot 206", "Black", "P3230TX", new DateTime(2022, 06, 21, 06, 55, 03), parking.Id);
            DBApi.Models.Car car4 = new DBApi.Models.Car("Lada Niva", "Red", "H5354HP", new DateTime(2022, 06, 21, 09, 32, 18), parking.Id);
            DBApi.Models.Car car5 = new DBApi.Models.Car("VW Golf", "Blue", "B5301BP", new DateTime(2022, 06, 21, 10, 48, 47), parking.Id);

            //AddToCarTable(car, unitOfWork, parking);
            //AddToCarTable(car2, unitOfWork, parking);
            //AddToCarTable(car3, unitOfWork, parking);
            //AddToCarTable(car4, unitOfWork, parking);
            //AddToCarTable(car5, unitOfWork, parking);


            //UpdateCarTable(car, unitOfWork, parking);
            UpdateCarTable(car2, unitOfWork, parking);
            //UpdateCarTable(car3, unitOfWork, parking);
            //UpdateCarTable(car4, unitOfWork, parking);
            //UpdateCarTable(car5, unitOfWork, parking);

            unitOfWork.SaveChanges();

            void AddToCarTable(DBApi.Models.Car car, IUnitOfWork unitOfWork, DBApi.Models.Parking parking)
            {
                if (countOfCarsInCarManager < parking.Capacity)
                {
                    car.Cost = 0;
                    car.Status = "Added";
                    countOfCarsInCarManager++;
                    parking.Count = countOfCarsInCarManager;
                    unitOfWork.CarManager.Create(car);
                    Console.WriteLine($"Successfully added car: {car.Number} at {car.StartTime}");
                }
                else
                {
                    Console.WriteLine("The parking is full !");
                }
            }
            void UpdateCarTable(DBApi.Models.Car car, IUnitOfWork unitOfWork, DBApi.Models.Parking parking)
            {
                if (car != null)
                {
                    car.EndTime = DateTime.Now;
                    car.Cost = car.PaymantCalculator();
                    car.Status = "Removed";
                    parking.Count = --countOfCarsInCarManager;
                    Console.WriteLine($"Successfully removed car: {car.Number} ! Cost: {car.Price}lv.");
                    unitOfWork.CarManager.Update(car);
                }
                else
                {
                    Console.WriteLine("Car with number doesn't exist !");
                }
            }


        }
    }

}
