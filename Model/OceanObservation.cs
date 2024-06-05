using System.ComponentModel.DataAnnotations;
using System;

namespace OceanObservationAPI.Models
{
    public class OceanObservation
    {

        [Key]
        public int Id { get; set; }
        public float Temperature { get; set; }
        public float Salinity { get; set; }
        public float Oxygen { get; set; }
        public float PH { get; set; }


    }
}
