using System;

namespace QuickHealthy.BLL.DTO
{
    public class AppointmentDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Diagnosis { get; set; }
        public int DoctorId { get; set; }
        public int MedicalCardId { get; set; }
    }
}
