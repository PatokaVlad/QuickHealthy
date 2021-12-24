using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickHealthy.DAL.Entities
{
    public class Patient
    {
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string CityOfBirth { get; set; }

        [Column(TypeName = "date")]
        public DateTime BirthDate { get; set; }

        public MedicalCard MedicalCard { get; set; }
    }
}
