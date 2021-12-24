using QuickHealthy.BLL.DTO;
using System;
using System.Collections.Generic;

namespace QuickHealthy.BLL.Interfaces
{
    public interface IOfficeService : IService<OfficeDTO>, IDisposable
    {
        OfficeDTO GetOfficeByDoctor(int? doctorId);
    }
}
