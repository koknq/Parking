using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DBApi.Models
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string model, string color, string number, DateTime startTime, int parkingID)
        {
            Model = model;
            Color = color;
            Number = number;
            StartTime = startTime;
            ParkingId = parkingID;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        [Key]
        public string Number { get; set; }
        public DateTime StartTime { get; set; }
        public int Cost { get; set; }
        public int Price => this.PaymantCalculator();
        public int PaymantCalculator()
        {
            int price = 1;
            TimeSpan ts = new TimeSpan();
            ts = DateTime.Now.Subtract(this.StartTime);
            int hoursInTheParking = int.Parse(ts.Hours.ToString());
            while (true)
            {
                if (hoursInTheParking == 0)
                {
                    break;
                }
                price += 2;
                hoursInTheParking--;
            }
            return price;
        }
        public string Status { get; set; }
        public DateTime EndTime { get; set; }

        public int ParkingId { get; set; }
        public Parking Parking { get; set; }

        //public override string ToString()
        //{

        //    return $"{this.Model} {this.Color} {this.Number} at ({this.StartTime}). Current time: ({DateTime.Now}). Cost: {this.Price}lv.";
        //}

    }
}
