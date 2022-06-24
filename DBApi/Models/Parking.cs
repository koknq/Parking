using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBApi.Models
{
    public class Parking
    {
        public Parking(int capacity)
        {
            Capacity = capacity;
        }
        [Key]
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }
        public string Status { get; set; }
        [ForeignKey("ParkingId")]
        public IEnumerable<Car> Cars { get; set; }
    }
}
