using System.ComponentModel.DataAnnotations;

namespace QuickHealthy.PL.WebApp.Models
{
    public class PatientLoginViewModel
    {
        [Required(ErrorMessage = "Не указан username")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Не указан пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
