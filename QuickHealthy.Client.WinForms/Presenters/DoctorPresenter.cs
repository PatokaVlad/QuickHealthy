using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.Client.WinForms.ApiClient;
using QuickHealthy.Client.WinForms.Constants;
using QuickHealthy.PL.Interfaces.Presenters;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace QuickHealthy.PL.Presenters
{
    public class DoctorPresenter : IPresenter<DoctorViewModel>
    {
        private readonly QuickHealthyClient _client;
        private IDoctorView _doctorView;

        public DoctorPresenter(IDoctorView doctorView, QuickHealthyClient client) {
            _doctorView = doctorView;
            _client = client;
        }

        public async Task<string> Create(DoctorViewModel viewModel) {

            try
            {
                await _client.CreateAsync<DoctorViewModel>(UrlConstants.ApiRoute + UrlConstants.DoctorRoute, viewModel);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            _doctorView.ClearDoctorControls();

            return true.ToString();
        }

        public async Task LoadModelsToView() {
            var doctors = await _client.GetAllAsync<DoctorViewModel>(UrlConstants.ApiRoute + UrlConstants.DoctorRoute);

            _doctorView.LoadDoctors(doctors);
        }

        public async Task<DoctorViewModel> Get(int? doctorId) {
            return await _client.GetAsync<DoctorViewModel>(UrlConstants.ApiRoute + UrlConstants.DoctorRoute, doctorId.Value);
        }
    }
}
