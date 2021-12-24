using QuickHealthy.BLL.DTO;
using System;
using System.Collections.Generic;

namespace QuickHealthy.BLL.Interfaces
{
    public interface IMedicalCardService : IService<MedicalCardDTO>, IDisposable
    {
        MedicalCardDTO GetMedicalCardByPatient(int? patientId);
        void AddLastAppointmentId(int? medicalCardId, int? lastAppointmentId);
    }
}
