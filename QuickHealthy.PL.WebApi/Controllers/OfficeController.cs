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
    public class OfficeController : ControllerBase
    {
        private readonly IOfficeService _officeService;
        private readonly IMapper _mapper;

        public OfficeController(IOfficeService officeService, IMapper mapper)
        {
            _officeService = officeService;
            _mapper = mapper;
        }

        [HttpPost]
        public OfficeViewModel Create(OfficeViewModel officeViewModel)
        {
            var office = _mapper.Map<OfficeDTO>(officeViewModel);
            _officeService.Create(office);

            return officeViewModel;
        }

        [HttpGet("{id}")]
        public OfficeViewModel Get(int id)
        {
            var office = _officeService.Get(id);

            return _mapper.Map<OfficeViewModel>(office);
        }

        [HttpGet]
        public IEnumerable<OfficeViewModel> GetAll()
        {
            var office = _officeService.GetAll();

            return _mapper.Map<IEnumerable<OfficeViewModel>>(office);
        }

        [HttpGet("doctor/{id}")]
        public OfficeViewModel GetOfficeByDoctor(int? id)
        {
            var office = _officeService.GetOfficeByDoctor(id);

            return _mapper.Map<OfficeViewModel>(office);
        }
    }
}
