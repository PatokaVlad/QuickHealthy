using System;

namespace QuickHealthy.PL.Models
{
    public class AppointmentViewModel
    {
        public int? Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string? Diagnosis { get; set; }
        public int DoctorId { get; set; }
        public int MedicalCardId { get; set; }
    }
}
