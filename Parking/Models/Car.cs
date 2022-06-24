using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Parking
{
    public class Car : ICar
    {
        public Car()
        {

        }
        public Car(string model, string color, string number, DateTime startTime,int parkingID)
        {
            Model = model;
            Color = color;
            Number = number;
            StartTime = startTime;
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
            int hoursInTheParking = int.Parse(ts.ToString());
            while(true)
            {
                if(hoursInTheParking == 0)
                {
                    break;
                }
                price += 2;
                hoursInTheParking--;
            }
            return price;
        }
        public override string ToString()
        {

            return $"{this.Model} {this.Color} {this.Number} at ({this.StartTime}). Current time: ({DateTime.Now}). Cost: {this.Price}lv.";
        }

    }
}
