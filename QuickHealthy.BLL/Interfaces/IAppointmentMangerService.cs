using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickHealthy.BLL.DTO;

namespace QuickHealthy.BLL.Interfaces
{
    public interface IAppointmentMangerService
    {
        void AddAppointmentDiagnosis(int? id, string diagnosis);
        IEnumerable<AppointmentDTO> GetAppointmentByDoctror(int? id);
        IEnumerable<AppointmentDTO> GetAppointmentByPatient(int? id);
        IEnumerable<AppointmentDTO> GetAppointmentByOffice(int? id);
    }
}
