using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.Client.WinForms.ApiClient;
using QuickHealthy.Client.WinForms.Constants;
using QuickHealthy.PL.Interfaces.Presenters;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using System;
using System.Threading.Tasks;

namespace QuickHealthy.PL.Presenters
{
    public class OfficePresenter : IPresenter<OfficeViewModel>
    {
        private QuickHealthyClient _client;
        private IOfficeView _officeView;

        public OfficePresenter(IOfficeView officeView, QuickHealthyClient client) {
            _client = client;
            _officeView = officeView;
        }

        public async Task<string> Create(OfficeViewModel viewModel) {
            try
            {
                await _client.CreateAsync<OfficeViewModel>(UrlConstants.ApiRoute + UrlConstants.OfficeRoute,viewModel);
            }
            catch (Exception e)
            {
                return e.Message;
            }

            _officeView.ClearOfficeControls();

            return true.ToString();
        }

        public async Task LoadModelsToView() {
            var offices = await _client.GetAllAsync<OfficeViewModel>(UrlConstants.ApiRoute + UrlConstants.OfficeRoute);

            _officeView.LoadOffices(offices);
        }
    }
}
