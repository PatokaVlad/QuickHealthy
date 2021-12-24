using AutoMapper;
using QuickHealthy.BLL.BusinessModels;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Infrastructure;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.DAL.Entities;
using QuickHealthy.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuickHealthy.BLL.Services
{
    public class AppointmentService : IAppointmentService
    {
        IUnitOfWork Database { get; set; }

        public AppointmentService(IUnitOfWork uow) {
            Database = uow;
        }

        public void Create(AppointmentDTO appointmentDTO) {
            Doctor doctor = Database.Doctors.Get(appointmentDTO.DoctorId);
            if (doctor == null)
            {
                throw new ValidationException("Doctor not found!", "DoctorId");
            }

            MedicalCard medicalCard = Database.MedicalCards.Get(appointmentDTO.MedicalCardId);
            if (medicalCard == null)
            {
                throw new ValidationException("Patient not found!", "PatientId");
            }

            DoctorTimeChecker timeChecker = new DoctorTimeChecker(Database, appointmentDTO);

            if (timeChecker.DoctorIsBusy())
            {
                throw new ValidationException("Doctor is busy!", "Appointment DateTime");
            }

            Appointment appointment = new Appointment
            {
                Id = appointmentDTO.Id,
                Date = appointmentDTO.Date,
                Time = appointmentDTO.Time,
                Diagnosis = "Not diagnosed",
                Doctor = doctor,
                MedicalCard = medicalCard
            };

            Database.Appointments.Create(appointment);
            Database.Save();
        }

        public AppointmentDTO Get(int? id) {
            if (id == null)
            {
                throw new ValidationException("Id is null", "Id");
            }

            Appointment appointment = Database.Appointments.Get(id.Value);

            if (appointment == null)
            {
                throw new ValidationException("Appountment not found", "AppointmentId");
            }

            return new AppointmentDTO
            {
                Id = appointment.Id,
                Date = appointment.Date,
                Time = appointment.Time,
                Diagnosis = appointment.Diagnosis,
                DoctorId = appointment.Doctor.Id,
                MedicalCardId = appointment.MedicalCard.Id,
            };
        }

        public IEnumerable<AppointmentDTO> GetAll() {
            var mapper = new MapperConfiguration(config => config.CreateMap<Appointment, AppointmentDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Appointment>, List<AppointmentDTO>>(Database.Appointments.GetAll());
        }

        public IEnumerable<AppointmentDTO> GetAppointmentsByDoctror(int? doctorId) {
            if (doctorId == null)
            {
                throw new ValidationException("DoctorId is null", "DoctorId");
            }

            var mapper = new MapperConfiguration(config => config.CreateMap<Appointment, AppointmentDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Appointment>, List<AppointmentDTO>>(Database.Appointments.Find(e => e.Doctor.Id == doctorId));
        }

        public IEnumerable<AppointmentDTO> GetAppointmentsByMedicalCard(int? medicalCardId) {
            if (medicalCardId == null)
            {
                throw new ValidationException("MedicalCardId is null", "MedicalCardId");
            }

            var mapper = new MapperConfiguration(config => config.CreateMap<Appointment, AppointmentDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Appointment>, List<AppointmentDTO>>(Database.Appointments.Find(m => m.MedicalCard.Id == medicalCardId));
        }

        public void AddAppointmentDiagnosis(int? id, string diagnosis) {
            Appointment appointment = Database.Appointments.Get(id.Value);

            if (appointment == null)
            {
                throw new ValidationException("Appointment with such id not found!", "Id");
            }

            appointment.Diagnosis = diagnosis;

            Database.Appointments.Update(appointment);
            Database.Save();
        }

        public void Dispose() {
            Database.Dispose();
        }
    }
}
