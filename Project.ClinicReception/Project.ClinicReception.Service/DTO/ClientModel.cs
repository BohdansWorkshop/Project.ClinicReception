﻿using System;
using Project.ClinicReception.DbEntity.Enums;


namespace Project.ClinicReception.Service.DTO
{
    public class ClientModel 
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditedDate { get; set; }
        public Guid Id { get; set; }
    }
}