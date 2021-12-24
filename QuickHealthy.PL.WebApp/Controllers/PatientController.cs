using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.Models;
using QuickHealthy.PL.WebApp.Services;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace QuickHealthy.PL.WebApp.Controllers
{
    public class PatientController : Controller
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMedicalCardService _medicalCardService;
        private readonly IDoctorService _doctorService;
        private readonly IPatientService _patientService;
        private readonly IMapper _mapper;
        private readonly DoctorHelperService _doctorHelperService;

        public PatientController(IAppointmentService appointmentService,
            IMapper mapper, IMedicalCardService medicalCardService, IDoctorService doctorService,
            IPatientService patientService, DoctorHelperService doctorHelperService)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
            _medicalCardService = medicalCardService;
            _doctorService = doctorService;
            _patientService = patientService;
            _doctorHelperService = doctorHelperService;
        }

        public IActionResult PatientPanel(int? id)
        {
            return View(id);
        }

        public IActionResult Appointments(int? id)
        {
            var medicalCard = _medicalCardService.GetMedicalCardByPatient(id);
            var appointmentsDTO = _appointmentService.GetAppointmentsByMedicalCard(medicalCard.Id);
            var appointments = _mapper.Map<IEnumerable<AppointmentViewModel>>(appointmentsDTO);

            foreach(var appointment in appointments)
            {
                //all appointments after mapping have id in first name, so we take it and enrich appointmentViewModel with first name, last name and job pos.
                var app = _doctorHelperService.EnrichAppointmentWithDoctorById(int.Parse(appointment.DoctorFirstName));
                appointment.DoctorFirstName = app.DoctorFirstName;
                appointment.DoctorLastName = app.DoctorLastName;
                appointment.DoctorJobPosition = app.DoctorJobPosition;
            }

            return View(appointments);
        }
        public IActionResult PersonalInformation(int? id)
        {
            var patient = _patientService.Get(id);

            var medicakCard = _medicalCardService.GetMedicalCardByPatient(id);

            // creating dynamic model to insert there patient and last appointment info
            dynamic model = new ExpandoObject();
            model.FirstName = patient.FirstName;
            model.LastName = patient.LastName;
            model.CityOfBirth = patient.CityOfBirth;
            model.BirthDate = patient.BirthDate;
            model.MedicalCardId = patient.MedicalCardId;
            model.HasAppointment = false;

            if (medicakCard.LastAppointmentId.HasValue)
            {
                var lastAppointment = _appointmentService.Get(medicakCard.LastAppointmentId);
                AppointmentViewModel appointmentViewModel = _doctorHelperService.EnrichAppointmentWithDoctorById(lastAppointment.DoctorId);

                model.Diagnosis = lastAppointment.Diagnosis;
                model.DoctorFirstName = appointmentViewModel.DoctorFirstName;
                model.DoctorLastName = appointmentViewModel.DoctorLastName;
                model.DoctorJobPosition = appointmentViewModel.DoctorJobPosition;
                model.Date = lastAppointment.Date;
                model.Time = lastAppointment.Time;
                model.HasAppointment = true;
            }

            return View(model);
        }
        public IActionResult MakeAnAppointment(int? id)
        {
            var card = _medicalCardService.GetMedicalCardByPatient(id);

            AppointmentViewModel model = new AppointmentViewModel();
            model.MedicalCardId = card.Id;
            return View(model);
        }
        [HttpPost]
        public IActionResult MakeAnAppointment(AppointmentViewModel model)
        {
            //get first doctor id by first name, last name, job pos and set to first name
            model.DoctorFirstName = _doctorHelperService
                .GetFirstDoctorId(model.DoctorFirstName, model.DoctorLastName, model.DoctorJobPosition).ToString();

            //map to dto so then DoctorFirstName (string) will became DoctorId (int)
            var appointment = _mapper.Map<AppointmentDTO>(model);

            try
            {
                appointment.MedicalCardId = _medicalCardService.GetMedicalCardByPatient(model.Id).Id;
                _appointmentService.Create(appointment);

                // redirect to Appointments method with patient id param
                var patient = _patientService.GetPatientByMedicalCard(appointment.MedicalCardId);
                return RedirectToAction("Appointments", new { patient.Id });
            }
            catch (Exception ex)
            {
                return Content(ex.Message);
            }
        }
    }
}
