using System;

namespace QuickHealthy.BLL.DTO
{
    public class PatientDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CityOfBirth { get; set; }
        public DateTime BirthDate { get; set; }
        public int? MedicalCardId { get; set; }
    }
}
