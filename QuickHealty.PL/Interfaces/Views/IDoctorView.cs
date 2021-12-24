using QuickHealthy.PL.Models;
using System.Collections.Generic;

namespace QuickHealthy.PL.Interfaces.Views
{
    public interface IDoctorView
    {
        void LoadDoctors(IEnumerable<DoctorViewModel> doctors);
        void ClearDoctorControls();
    }
}
