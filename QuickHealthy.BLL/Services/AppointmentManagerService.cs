using System;
using System.Collections.Generic;
using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Infrastructure;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.DAL.Entities;
using QuickHealthy.DAL.Interfaces;

namespace QuickHealthy.BLL.Services
{
    public class AppointmentManagerService : IAppointmentMangerService
    {
        private IUnitOfWork Database;

        public AppointmentManagerService(IUnitOfWork uow) {
            Database = uow;
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

        public IEnumerable<AppointmentDTO> GetAppointmentByDoctror(int? id) {
            var mapper = new MapperConfiguration(config => config.CreateMap<Appointment, AppointmentDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Appointment>, List<AppointmentDTO>>(Database.Appointments.Find(e => e.DoctorId == id));
        }

        public IEnumerable<AppointmentDTO> GetAppointmentByOffice(int? id) {
            var mapper = new MapperConfiguration(config => config.CreateMap<Appointment, AppointmentDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Appointment>, List<AppointmentDTO>>(Database.Appointments.Find(e => e.OfficeId == id));
        }

        public IEnumerable<AppointmentDTO> GetAppointmentByPatient(int? id) {
            var mapper = new MapperConfiguration(config => config.CreateMap<Appointment, AppointmentDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Appointment>, List<AppointmentDTO>>(Database.Appointments.Find(e => e.PatientId == id));
        }
    }
}
