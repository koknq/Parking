using System;

namespace Parking
{
    interface ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Number { get; set; }
        public DateTime StartTime { get; set; }
        public int PaymantCalculator();
    }
}
