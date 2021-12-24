using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickHealthy.DAL.Entities
{
    public class Appointment
    {
        public int Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        public DateTime Time { get; set; }

        public string Diagnosis { get; set; }

        public MedicalCard MedicalCard { get; set; }

        public Doctor Doctor { get; set; }
    }
}
