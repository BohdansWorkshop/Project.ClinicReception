using System;
using System.ComponentModel.DataAnnotations;

namespace Project.ClinicReception.DbEntity
{
    public class Order : IdEntity
    {
        [Required]
        public string Cabinet { get; set; }
        [Required]
        public double Price { get; set; }
        public string Time { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditedDate { get; set; }
        [Required]
        public Client ClientOrder { get; set; }
        [Required]
        public Doctor DoctorOrder { get; set; }

        //private string ClientId;
        //private string DoctorId;
    }
}