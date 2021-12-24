using QuickHealthy.Client.WinForms.ApiClient;
using QuickHealthy.Client.WinForms.Constants;
using QuickHealthy.PL.Interfaces.Presenters;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace QuickHealthy.PL.Presenters
{
    public class MedicalCardPresenter : IMedicalCardPresenter
    {
        private QuickHealthyClient _client;
        private IMedicalCardView _medicalCardView;

        public MedicalCardPresenter(IMedicalCardView medicalCardView, QuickHealthyClient client) {
            _client = client;
            _medicalCardView = medicalCardView;
        }

        public async Task<string> Create(MedicalCardViewModel viewModel) {
            try
            {
                await _client.CreateAsync<MedicalCardViewModel>(UrlConstants.ApiRoute + UrlConstants.MedicalCardRoute, viewModel);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            _medicalCardView.ClearMedicalCardCreationControls();

            return true.ToString();
        }

        public async Task<MedicalCardViewModel> GetMedicalCardByPatient(int? patientId) {
            return await _client.GetAsync<MedicalCardViewModel>(UrlConstants.ApiRoute + UrlConstants.MedicalCardRoute + "/" + UrlConstants.PatientRoute, patientId);
        }

        public async Task LoadModelsToView() {
            var medicalCards = await _client.GetAllAsync<MedicalCardViewModel>(UrlConstants.ApiRoute + UrlConstants.MedicalCardRoute);

            _medicalCardView.LoadMedicalCards(medicalCards);
        }

        public async Task<string> UpdateLastAppointmentId(int? medicalCardId, int? lastAppointmentId) {
            MedicalCardViewModel model = new MedicalCardViewModel()
            {
                Id = medicalCardId,
                LastAppointmentId = lastAppointmentId
            };
            try
            {
                await _client.UpdateAsync<MedicalCardViewModel>(UrlConstants.ApiRoute + UrlConstants.MedicalCardRoute, model);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            return true.ToString();
        }
    }
}
