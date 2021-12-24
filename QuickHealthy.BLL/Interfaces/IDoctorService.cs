using QuickHealthy.BLL.DTO;
using System;
using System.Collections.Generic;

namespace QuickHealthy.BLL.Interfaces
{
    public interface IDoctorService : IService<DoctorDTO>, IDisposable
    {
        DoctorDTO GetDoctorByOffice(int? officeId);
    }
}
