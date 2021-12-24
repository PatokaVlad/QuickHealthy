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
    public class MedicalCardPresenter : IMedicalCardPresenter
    {
        private IMedicalCardService _medicalCardService;
        private IMedicalCardView _medicalCardView;

        public MedicalCardPresenter(IMedicalCardView medicalCardView, IMedicalCardService medicalCardService) {
            _medicalCardService = medicalCardService;
            _medicalCardView = medicalCardView;
        }

        public string Create(MedicalCardViewModel viewModel) {
            MedicalCardDTO medicalCardDTO = new MedicalCardDTO
            {
                LastAppointmentId = viewModel.LastAppointmentId,
                PatientId = viewModel.PatientId
            };

            try
            {
                _medicalCardService.Create(medicalCardDTO);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            _medicalCardView.ClearMedicalCardCreationControls();

            return true.ToString();
        }

        public MedicalCardViewModel GetMedicalCardByPatient(int? patientId) {
            MedicalCardDTO medicalCardDTO =  _medicalCardService.GetMedicalCardByPatient(patientId);

            return new MedicalCardViewModel
            {
                PatientId = medicalCardDTO.PatientId,
                LastAppointmentId = medicalCardDTO.LastAppointmentId
            };
        }

        public void LoadModelsToView() {
            var mapper = new MapperConfiguration(config => config.CreateMap<MedicalCardDTO, MedicalCardViewModel>()).CreateMapper();
            var medicalCards = mapper.Map<IEnumerable<MedicalCardDTO>, List<MedicalCardViewModel>>(_medicalCardService.GetAll());

            _medicalCardView.LoadMedicalCards(medicalCards);
        }

        public string UpdateLastAppointmentId(int? medicalCardId, int? lastAppointmentId) {
            try
            {
                _medicalCardService.AddLastAppointmentId(medicalCardId, lastAppointmentId);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            return true.ToString();
        }
    }
}
