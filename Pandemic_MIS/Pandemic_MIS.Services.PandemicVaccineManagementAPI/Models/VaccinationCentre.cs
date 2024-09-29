﻿using System.ComponentModel.DataAnnotations;

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Models
{
    public class VaccinationCentre
    {
        [Key]
        public int VaccinationCentreId { get; set; }
        [Required]
        public string CentreName { get; set; }
        [Required]
        public string District { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public double Latitude { get; set; }
        [Required]
        public double Longitude { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public string CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}