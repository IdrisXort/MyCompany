using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany2.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public double Range { get; set; }
        public double Mileage { get; set; } 
        public int CompanyId { get; set; }
        public Company Company { get; set; }

    }
}
