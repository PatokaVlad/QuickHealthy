using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickHealthy.DAL.Entities
{
    public class MedicalCard
    {
        [ForeignKey("Patient")]
        public int Id { get; set; }

        public int? LastAppointmentId { get; set; }

        public Patient Patient { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
    }
}
