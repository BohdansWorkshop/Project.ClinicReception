using System;
using Project.ClinicReception.DbEntity.Enums;

namespace Project.ClinicReception.DbEntity
{
    public class Doctor : NameEntity
    {
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public DoctorQualification Qualification { get; set; }
        public string Phone { get; set; }
        public string Graphic { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime EditedDate { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}