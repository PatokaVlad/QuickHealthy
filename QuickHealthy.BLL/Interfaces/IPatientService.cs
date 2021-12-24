using QuickHealthy.BLL.DTO;
using System;
using System.Collections.Generic;

namespace QuickHealthy.BLL.Interfaces
{
    public interface IPatientService : IService<PatientDTO>, IDisposable
    {
        PatientDTO GetPatientByMedicalCard(int? medicalCardId);
    }
}
