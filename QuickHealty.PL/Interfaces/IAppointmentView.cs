using QuickHealthy.PL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickHealthy.PL.Interfaces
{
    public interface IAppointmentView
    {
        void LoadAppointments(IEnumerable<AppointmentViewModel> appointments);
        void ClearAppointmentsCreationPanel();
    }
}
