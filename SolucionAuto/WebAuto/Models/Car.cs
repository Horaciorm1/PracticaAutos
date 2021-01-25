using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAuto.Models
{
    public enum VehicleType
    { 
        Vagoneta=0,
        Sedan=1,
        Jeep=2,
        Camioneta=3
    }
    public enum WheelDrive
    {
        AWD = 0,
        TWOWD = 1,      
    }
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        [StringLength(20,MinimumLength =3)]
        public string Brand { get; set; }
        public VehicleType Vehicle { get; set; }    
        [Range(1000,100000)]
        public double Price { get; set; }
        public WheelDrive WheelD { get; set; }

    }
}