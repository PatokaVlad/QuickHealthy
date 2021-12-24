using System;

namespace QuickHealthy.PL.Models
{
    public class AppointmentViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Diagnosis { get; set; }
        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public string DoctorJobPosition { get; set; }
        public int MedicalCardId { get; set; }
    }
}
