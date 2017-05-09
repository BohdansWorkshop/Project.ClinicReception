using System.ComponentModel.DataAnnotations;

namespace Project.ClinicReception.DbEntity
{
        public abstract class NameEntity : IdEntity
        {
            [Required]
            [MaxLength(500)]
            public string Name { get; set; }

            public override string ToString()
            {
                return $"{Name}";
            }
        }
}