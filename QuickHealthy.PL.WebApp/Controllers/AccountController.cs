using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.WebApp.Models;
using System.Linq;

namespace QuickHealthy.PL.WebApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;


        public AccountController(IPatientService patientService, IMapper mapper,
            IDoctorService doctorService)
        {
            _patientService = patientService;
            _mapper = mapper;
            _doctorService = doctorService;
        }

        public IActionResult PatientLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PatientLogin(PatientLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                PatientDTO patient = _patientService.GetAll()
                    .Where(p => p.Username == model.Username && p.Password == model.Password)
                    .FirstOrDefault();

                if (patient != default && patient != null)
                {
                    return RedirectToAction("PatientPanel", "Patient", new { patient.Id });
                }
                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        public IActionResult PatientRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PatientRegister(PatientRegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var patient = _mapper.Map<PatientDTO>(model);
                _patientService.Create(patient);

                return RedirectToAction("PatientLogin", "Account");
            }

            return View();
        }

        public IActionResult DoctorLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DoctorLogin(DoctorLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var doctor = _doctorService.Get(model.Id);

                if (doctor != default && doctor != null)
                {
                    return RedirectToAction("DoctorPanel", "Doctor", new { doctor.Id });
                }

                ModelState.AddModelError("", "Некорректные логин и(или) пароль");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult AdminPanel()
        {
            return RedirectToAction("AdminPanel", "Admin");
        }
    }
}
