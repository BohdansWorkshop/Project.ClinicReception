using System;
using System.ComponentModel.DataAnnotations;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.Service.DTO
{
    public class OrderModel
    {
        public Guid Id;
        public double Price;
        public string Cabinet;
        public string Time { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditedDate { get; set; }
        [Required]
        //ToDo замени тут на модельку у поблема уйдет сама по себе
        public ClientModel ClientOrder { get; set; }
        [Required]
        public DoctorModel DoctorOrder { get; set; }
    }
}