using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickHealthy.PL.Interfaces
{
    public interface IAppointmentPresenter
    {
        void LoadAppointmentsToView();
        void CreateAppointment(int doctorId, int patientId, int officeId, string diagnosis, string date, string time);
    }
}
