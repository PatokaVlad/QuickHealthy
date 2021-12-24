using System.ComponentModel.DataAnnotations;

namespace QuickHealthy.PL.WebApp.Models
{
    public class DoctorLoginViewModel
    {
        [Required(ErrorMessage = "Не указан id")]
        public int Id { get; set; }
    }
}
