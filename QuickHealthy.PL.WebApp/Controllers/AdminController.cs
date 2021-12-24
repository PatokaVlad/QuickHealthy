using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.Models;

namespace QuickHealthy.PL.WebApp.Controllers
{
    public class AdminController : Controller
    {
        private readonly IOfficeService _officeService;
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public AdminController(IOfficeService officeService, IMapper mapper, 
            IDoctorService doctorService)
        {
            _officeService = officeService;
            _doctorService = doctorService;
            _mapper = mapper;
        }

        public IActionResult AdminPanel()
        {
            return View();
        }

        public IActionResult Appointments()
        {
            return View();
        }

        public IActionResult Patients()
        {
            return View();
        }

        public IActionResult Offices()
        {
            return View();
        }

        public IActionResult AddOffice()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddOffice(OfficeViewModel model)
        {
            var office = _mapper.Map<OfficeDTO>(model);

            _officeService.Create(office);

            return RedirectToAction("Offices", "Admin");
        }

        public IActionResult Doctors()
        {
            return View();
        }

        public IActionResult AddDoctor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDoctor(DoctorViewModel doctorViewModel)
        {
            var doctor = _mapper.Map<DoctorDTO>(doctorViewModel);
            _doctorService.Create(doctor);

            return RedirectToAction("Doctors", "Admin");
        }

    }
}
