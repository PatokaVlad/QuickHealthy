using QuickHealthy.PL.Models;
using System.Collections.Generic;

namespace QuickHealthy.PL.Interfaces.Views
{
    public interface IAppointmentView
    {
        void LoadAppointments(IEnumerable<AppointmentViewModel> appointments);
        void ClearAppointmentCreationControls();
        void ClearAppointmentUpdateControls();
    }
}
