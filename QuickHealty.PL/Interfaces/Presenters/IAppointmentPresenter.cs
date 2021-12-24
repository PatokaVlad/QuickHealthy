using QuickHealthy.PL.Models;

namespace QuickHealthy.PL.Interfaces.Presenters
{
    public interface IAppointmentPresenter : IPresenter<AppointmentViewModel>
    {
        string UpdateAppointmentDiagnosis(int? appointmentId, string diagnosis);
        void LoadAppointmentsByDoctorToView(int? doctorId);
        void LoadAppointmentsByMedicalCardToView(int? medicalCardId);
        AppointmentViewModel Get(int? appointmentId);
    }
}
