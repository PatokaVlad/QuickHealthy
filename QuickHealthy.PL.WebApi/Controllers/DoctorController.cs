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
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public DoctorController(IDoctorService doctorService, IMapper mapper)
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }

        [HttpGet("office/{id}")]
        public DoctorViewModel GetDoctorByOffice(int? id)
        {
            var doctor = _doctorService.GetDoctorByOffice(id);

            return _mapper.Map<DoctorViewModel>(doctor);
        }

        [HttpPost]
        public DoctorViewModel Create(DoctorViewModel doctorViewModel)
        {
            var doctor = _mapper.Map<DoctorDTO>(doctorViewModel);

            _doctorService.Create(doctor);

            return doctorViewModel;
        }

        [HttpGet("{id}")]
        public DoctorViewModel Get(int id)
        {
            var doctor = _doctorService.Get(id);

            return _mapper.Map<DoctorViewModel>(doctor);
        }

        [HttpGet]
        public IEnumerable<DoctorViewModel> GetAll()
        {
            var doctors = _doctorService.GetAll();

            return _mapper.Map<IEnumerable<DoctorViewModel>>(doctors);
        }
    }
}
