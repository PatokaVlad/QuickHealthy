using QuickHealthy.PL.Models;
using System.Threading.Tasks;

namespace QuickHealthy.PL.Interfaces.Presenters
{
    interface IMedicalCardPresenter : IPresenter<MedicalCardViewModel>
    {
        Task<string> UpdateLastAppointmentId(int? medicalCardId, int? lastAppointmentId);

        Task<MedicalCardViewModel> GetMedicalCardByPatient(int? patientId);
    }
}
