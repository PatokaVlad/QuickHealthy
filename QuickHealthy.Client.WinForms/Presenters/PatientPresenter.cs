using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.Client.WinForms.ApiClient;
using QuickHealthy.Client.WinForms.Constants;
using QuickHealthy.PL.Interfaces.Presenters;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace QuickHealthy.PL.Presenters
{
    public class PatientPresenter : IPresenter<PatientViewModel>
    {
        private readonly QuickHealthyClient _client;
        private IPatientView _patientView;

        public PatientPresenter(IPatientView patientView, QuickHealthyClient client) {
            _client = client;
            _patientView = patientView;
        }

        public async Task<string> Create(PatientViewModel viewModel) {

            try
            {
                await _client.CreateAsync<PatientViewModel>(UrlConstants.ApiRoute + UrlConstants.PatientRoute, viewModel);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            _patientView.ClearPatientControls();

            return true.ToString();
        }

        public async Task LoadModelsToView() {
            var mapper = new MapperConfiguration(config => config.CreateMap<PatientDTO, PatientViewModel>()).CreateMapper();
            var patients = await _client.GetAllAsync<PatientViewModel>(UrlConstants.ApiRoute + UrlConstants.PatientRoute);

            _patientView.LoadPatients(patients);
        }
    }
}
