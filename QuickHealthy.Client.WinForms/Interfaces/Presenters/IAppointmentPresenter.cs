using QuickHealthy.PL.Models;
using System.Threading.Tasks;

namespace QuickHealthy.PL.Interfaces.Presenters
{
    public interface IAppointmentPresenter : IPresenter<AppointmentViewModel>
    {
        Task<string> UpdateAppointmentDiagnosis(int? appointmentId, string diagnosis);
        Task LoadAppointmentsByDoctorToView(int? doctorId);
        Task LoadAppointmentsByMedicalCardToView(int? medicalCardId);
        Task<AppointmentViewModel> Get(int? appointmentId);
    }
}
