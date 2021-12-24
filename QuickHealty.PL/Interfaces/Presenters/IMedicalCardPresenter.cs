using QuickHealthy.PL.Models;

namespace QuickHealthy.PL.Interfaces.Presenters
{
    interface IMedicalCardPresenter : IPresenter<MedicalCardViewModel>
    {
        string UpdateLastAppointmentId(int? medicalCardId, int? lastAppointmentId);

        MedicalCardViewModel GetMedicalCardByPatient(int? patientId);
    }
}
