using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.Models;
using System.Collections.Generic;

namespace QuickHealthy.PL.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;

        public AppointmentController(IAppointmentService appointmentService, IMapper mapper)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
        }

        [HttpPut]
        public AppointmentViewModel AddAppointmentDiagnosis(AppointmentViewModel model)
        {
            _appointmentService.AddAppointmentDiagnosis(model.Id, model.Diagnosis);

            return model;
        }

        [HttpPost]
        public AppointmentViewModel Create(AppointmentViewModel appointmentViewModel)
        {
            var appointment = _mapper.Map<AppointmentDTO>(appointmentViewModel);

            _appointmentService.Create(appointment);

            return appointmentViewModel;
        }

        [HttpGet("{id}")]
        public AppointmentViewModel Get(int id)
        {
            var appointment = _appointmentService.Get(id);

            return _mapper.Map<AppointmentViewModel>(appointment);
        }

        [HttpGet]
        public IEnumerable<AppointmentViewModel> GetAll()
        {
            var appointments = _appointmentService.GetAll();

            return _mapper.Map<IEnumerable<AppointmentViewModel>>(appointments);
        }

        [HttpGet("doctor/{id}")]
        public IEnumerable<AppointmentViewModel> GetAppointmentsByDoctror(int id)
        {
            var appointments = _appointmentService.GetAppointmentsByDoctror(id);

            return _mapper.Map<IEnumerable<AppointmentViewModel>>(appointments);
        }

        [HttpGet("medicalCard/{id}")]
        public IEnumerable<AppointmentViewModel> GetAppointmentsByMedicalCard(int id)
        {
            var appointments = _appointmentService.GetAppointmentsByMedicalCard(id);

            return _mapper.Map<IEnumerable<AppointmentViewModel>>(appointments);
        }
    }
}
