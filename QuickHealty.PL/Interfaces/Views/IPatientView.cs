using QuickHealthy.PL.Models;
using System.Collections.Generic;

namespace QuickHealthy.PL.Interfaces.Views
{
    public interface IPatientView
    {
        void LoadPatients(IEnumerable<PatientViewModel> patients);
        void ClearPatientControls();
    }
}
