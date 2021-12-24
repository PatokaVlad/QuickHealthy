using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Infrastructure;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.Interfaces.Presenters;
using QuickHealthy.PL.Interfaces.Views;
using QuickHealthy.PL.Models;
using System;
using System.Collections.Generic;

namespace QuickHealthy.PL.Presenters
{
    public class AppointmentPresenter : IAppointmentPresenter
    {
        private IAppointmentService _appointmentService;
        private IAppointmentView _appointmentView;

        public AppointmentPresenter(IAppointmentView appointmentView, IAppointmentService appointmentService) {
            _appointmentService = appointmentService;
            _appointmentView = appointmentView;
        }

        public void LoadModelsToView() {
            var mapper = new MapperConfiguration(config => config.CreateMap<AppointmentDTO, AppointmentViewModel>()).CreateMapper();
            var appointments = mapper.Map<IEnumerable<AppointmentDTO>, List<AppointmentViewModel>>(_appointmentService.GetAll());

            _appointmentView.LoadAppointments(appointments);
        }


        public string Create(AppointmentViewModel viewModel) {
            AppointmentDTO appointmentDTO = new AppointmentDTO
            {
                DoctorId = viewModel.DoctorId,
                MedicalCardId = viewModel.MedicalCardId,
                Diagnosis = viewModel.Diagnosis,
                Date = Convert.ToDateTime(viewModel.Date),
                Time = Convert.ToDateTime(viewModel.Time)
            };

            try
            {
                _appointmentService.Create(appointmentDTO);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            _appointmentView.ClearAppointmentCreationControls();

            return true.ToString();
        }

        public string UpdateAppointmentDiagnosis(int? appointmentId, string diagnosis) {
            try
            {
                _appointmentService.AddAppointmentDiagnosis(appointmentId, diagnosis);
            }
            catch (ValidationException e)
            {
                return e.Message;
            }

            return true.ToString();
        }

        public void LoadAppointmentsByDoctorToView(int? doctorId) {
            var mapper = new MapperConfiguration(config => config.CreateMap<AppointmentDTO, AppointmentViewModel>()).CreateMapper();
            var appointments = mapper.Map<IEnumerable<AppointmentDTO>, List<AppointmentViewModel>>(_appointmentService.GetAppointmentsByDoctror(doctorId));

            _appointmentView.LoadAppointments(appointments);
        }

        public void LoadAppointmentsByMedicalCardToView(int? medicalCardId) {
            var mapper = new MapperConfiguration(config => config.CreateMap<AppointmentDTO, AppointmentViewModel>()).CreateMapper();
            var appointments = mapper.Map<IEnumerable<AppointmentDTO>, List<AppointmentViewModel>>(_appointmentService.GetAppointmentsByMedicalCard(medicalCardId));

            _appointmentView.LoadAppointments(appointments);
        }

        public AppointmentViewModel Get(int? appointmentId) {
            AppointmentDTO appointmentDTO =  _appointmentService.Get(appointmentId);

            return new AppointmentViewModel()
            {
                Id = appointmentDTO.Id,
                Date = appointmentDTO.Date,
                Time = appointmentDTO.Time,
                DoctorId = appointmentDTO.DoctorId,
                MedicalCardId = appointmentDTO.MedicalCardId
            };
        }
    }
}
