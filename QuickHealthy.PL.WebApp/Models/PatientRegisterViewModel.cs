using System;
using System.ComponentModel.DataAnnotations;

namespace QuickHealthy.PL.WebApp.Models
{
    public class PatientRegisterViewModel
    {
        [Required(ErrorMessage = "Не указан FirstName")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Не указан LastName")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Не указан CityOfBirth")]
        public string CityOfBirth { get; set; }
        [Required(ErrorMessage = "Не указан BirthDate")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [Required(ErrorMessage = "Не указан Username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Не указан Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
