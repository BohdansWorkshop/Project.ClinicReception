using System;
using System.ComponentModel.DataAnnotations;
using Project.ClinicReception.DbEntity.Enums;

namespace Project.ClinicReception.DbEntity
{
    public class Client : NameEntity
    {
      
        [MaxLength(500)]
        public string Phone { get; set; }
        [Required]
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditedDate { get; set; }

        //public static explicit operator Client(ClientModel client)
        //{
        //    return new Client()
        //    {
        //        Id = client.Id,
        //        Name = client.Name,
        //        Phone = client.Phone,
        //        Sex = client.Sex,
        //        CreateDate = client.CreateDate,
        //        EditedDate = client.EditedDate,
        //    };
        //}

    }
}