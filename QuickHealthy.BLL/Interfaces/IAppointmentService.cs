using QuickHealthy.BLL.DTO;
using System;
using System.Collections.Generic;

namespace QuickHealthy.BLL.Interfaces
{
    public interface IAppointmentService : IService<AppointmentDTO>, IDisposable
    {
        IEnumerable<AppointmentDTO> GetAppointmentsByDoctror(int? doctorId);
        IEnumerable<AppointmentDTO> GetAppointmentsByMedicalCard(int? medicalCardId);
        void AddAppointmentDiagnosis(int? appointmentId, string diagnosis);
    }
}
