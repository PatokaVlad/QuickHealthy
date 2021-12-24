using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.Interfaces.Presenters;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuickHealthy.PL.Presenters
{
    public class PatientPresenter : IPresenter<PatientViewModel>
    {
        private IPatientService _patientService;
        private IPatientView _patientView;

        public PatientPresenter(IPatientView patientView, IPatientService patientService) {
            _patientService = patientService;
            _patientView = patientView;
        }

        public string Create(PatientViewModel viewModel) {
            PatientDTO patientDTO = new PatientDTO
            {
                Username = viewModel.Username,
                Password = viewModel.Password,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                CityOfBirth = viewModel.CityOfBirth,
                BirthDate = viewModel.BirthDate,
                MedicalCardId = viewModel.MedicalCardId
            };

            try
            {
                _patientService.Create(patientDTO);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            _patientView.ClearPatientControls();

            return true.ToString();
        }

        public void LoadModelsToView() {
            var mapper = new MapperConfiguration(config => config.CreateMap<PatientDTO, PatientViewModel>()).CreateMapper();
            var patients = mapper.Map<IEnumerable<PatientDTO>, List<PatientViewModel>>(_patientService.GetAll());

            _patientView.LoadPatients(patients);
        }
    }
}
