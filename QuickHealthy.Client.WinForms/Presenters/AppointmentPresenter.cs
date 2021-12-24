using QuickHealthy.BLL.Infrastructure;
using QuickHealthy.Client.WinForms.ApiClient;
using QuickHealthy.Client.WinForms.Constants;
using QuickHealthy.PL.Interfaces.Presenters;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using System;
using System.Threading.Tasks;

namespace QuickHealthy.PL.Presenters
{
    public class AppointmentPresenter : IAppointmentPresenter
    {
        private QuickHealthyClient _client;
        private IAppointmentView _appointmentView;

        public AppointmentPresenter(IAppointmentView appointmentView, QuickHealthyClient client) {
            _client = client;
            _appointmentView = appointmentView;
        }

        public async Task LoadModelsToView() {
            var appointments = await _client.GetAllAsync<AppointmentViewModel>(UrlConstants.ApiRoute + UrlConstants.AppointmentRoute);

            _appointmentView.LoadAppointments(appointments);
        }


        public async Task<string> Create(AppointmentViewModel viewModel) {
            try
            {
                await _client.CreateAsync<AppointmentViewModel>(UrlConstants.ApiRoute + UrlConstants.AppointmentRoute, viewModel);
            }
            catch (Exception e)
            {
                return e.Message;
            }

            _appointmentView.ClearAppointmentCreationControls();

            return true.ToString();
        }

        public async Task<string> UpdateAppointmentDiagnosis(int? appointmentId, string diagnosis) {

            AppointmentViewModel model = new AppointmentViewModel() 
            { 
                Id = appointmentId, 
                Diagnosis = diagnosis 
            };

            try
            {
                await _client.UpdateAsync<AppointmentViewModel>(UrlConstants.ApiRoute + UrlConstants.AppointmentRoute, model);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            return true.ToString();
        }

        public async Task LoadAppointmentsByDoctorToView(int? doctorId) {
            var appointments = await _client.GetAllAsync<AppointmentViewModel>(UrlConstants.ApiRoute + UrlConstants.AppointmentRoute + "/" + UrlConstants.DoctorRoute, doctorId.Value);

            _appointmentView.LoadAppointments(appointments);
        }

        public async Task LoadAppointmentsByMedicalCardToView(int? medicalCardId) {
            var appointments = await _client.GetAllAsync<AppointmentViewModel>(UrlConstants.ApiRoute + UrlConstants.AppointmentRoute + "/" + UrlConstants.MedicalCardRoute, medicalCardId.Value);

            _appointmentView.LoadAppointments(appointments);
        }

        public async Task<AppointmentViewModel> Get(int? appointmentId) {

            return await _client.GetAsync<AppointmentViewModel>(UrlConstants.ApiRoute + UrlConstants.AppointmentRoute, appointmentId);
        }
    }
}
