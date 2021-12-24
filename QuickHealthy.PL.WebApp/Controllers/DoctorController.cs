using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.Models;

namespace QuickHealthy.PL.WebApp.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public DoctorController(IAppointmentService appointmentService,
            IDoctorService doctorService, IMapper mapper)
        {
            _appointmentService = appointmentService;
            _doctorService = doctorService;
            _mapper = mapper;
        }

        public IActionResult DoctorPanel(int? id)
        {
            return View(id);
        }

        public IActionResult Appointments(int? id)
        {
            return View(id);
        }
        [HttpPost]
        public IActionResult EditAppointment(AppointmentViewModel appointment)
        {
            _appointmentService.AddAppointmentDiagnosis(appointment.Id, appointment.Diagnosis);

            var id = int.Parse(appointment.DoctorFirstName);

            return RedirectToAction("Appointments", new { id });
        }
        public IActionResult PersonalInformation(int? id)
        {
            var doctor = _doctorService.Get(id);
            return View(_mapper.Map<DoctorViewModel>(doctor));
        }
        [HttpPost]
        public IActionResult PersonalInformation(DoctorViewModel model)
        {
            return View(model);
        }
    }
}
