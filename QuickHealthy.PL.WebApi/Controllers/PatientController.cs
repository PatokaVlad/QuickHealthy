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
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        private readonly IMapper _mapper;

        public PatientController(IPatientService patientService, IMapper mapper)
        {
            _patientService = patientService;
            _mapper = mapper;
        }

        [HttpPost]
        public PatientViewModel Create(PatientViewModel officeViewModel)
        {
            var patient = _mapper.Map<PatientDTO>(officeViewModel);
            _patientService.Create(patient);

            return officeViewModel;
        }

        [HttpGet("{id}")]
        public PatientViewModel Get(int id)
        {
            var patient = _patientService.Get(id);

            return _mapper.Map<PatientViewModel>(patient);
        }

        [HttpGet]
        public IEnumerable<PatientViewModel> GetAll()
        {
            var patients = _patientService.GetAll();

            return _mapper.Map<IEnumerable<PatientViewModel>>(patients);
        }

        [HttpGet("doctor/{id}")]
        public PatientViewModel GetPatientByMedicalCard(int? id)
        {
            var patient = _patientService.GetPatientByMedicalCard(id);

            return _mapper.Map<PatientViewModel>(patient);
        }
    }
}
