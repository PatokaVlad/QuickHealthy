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
    public class MedicalCardController : ControllerBase
    {
        private readonly IMedicalCardService _medicalCardService;
        private readonly IMapper _mapper;

        public MedicalCardController(IMedicalCardService medicalCardService, IMapper mapper)
        {
            _medicalCardService = medicalCardService;
            _mapper = mapper;
        }
        [HttpPut]
        public MedicalCardViewModel AddLastAppointmentId(MedicalCardViewModel model)
        {
            _medicalCardService.AddLastAppointmentId(model.Id, model.LastAppointmentId);

            return model;
        }
        [HttpPost]
        public MedicalCardViewModel Create(MedicalCardViewModel medicalCardViewModel)
        {
            var medicalCard = _mapper.Map<MedicalCardDTO>(medicalCardViewModel);
            _medicalCardService.Create(medicalCard);

            return medicalCardViewModel;
        }

        [HttpGet("{id}")]
        public MedicalCardViewModel Get(int? id)
        {
            var medicalCard = _medicalCardService.Get(id);

            return _mapper.Map<MedicalCardViewModel>(medicalCard);
        }

        [HttpGet]
        public IEnumerable<MedicalCardViewModel> GetAll()
        {
            var medicalCards = _medicalCardService.GetAll();

            return _mapper.Map<IEnumerable<MedicalCardViewModel>>(medicalCards);
        }
        [HttpGet("patient/{id}")]
        public MedicalCardViewModel GetMedicalCardByPatient(int id)
        {
            var medicalCard = _medicalCardService.GetMedicalCardByPatient(id);

            return _mapper.Map<MedicalCardViewModel>(medicalCard);
        }
    }
}
