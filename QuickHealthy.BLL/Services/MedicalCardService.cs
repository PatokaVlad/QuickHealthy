using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Infrastructure;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.DAL.Entities;
using QuickHealthy.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickHealthy.BLL.Services
{
    public class MedicalCardService : IMedicalCardService
    {
        IUnitOfWork Database { get; set; }

        public MedicalCardService(IUnitOfWork uow) {
            Database = uow;
        }

        public void Create(MedicalCardDTO medicalCardDTO) {
            Patient patient = Database.Patients.Get(medicalCardDTO.PatientId);
            if (patient == null)
            {
                throw new ValidationException("Patient not found!", "PatientId");
            }

            MedicalCard medicalCard = new MedicalCard
            {
                LastAppointmentId = medicalCardDTO.LastAppointmentId,
                Patient = patient
            };

            Database.MedicalCards.Create(medicalCard);
            Database.Save();
        }

        public MedicalCardDTO Get(int? id) {
            if (id == null)
            {
                throw new ValidationException("Id is null", "Id");
            }

            MedicalCard medicalCard = Database.MedicalCards.Get(id.Value);

            if (medicalCard == null)
            {
                throw new ValidationException("MedicalCard not found", "MedicalCardId");
            }

            return new MedicalCardDTO
            {
                Id = medicalCard.Id,
                LastAppointmentId = medicalCard.LastAppointmentId,
                PatientId = medicalCard.Patient.Id
            };
        }

        public MedicalCardDTO GetMedicalCardByPatient(int? patientId) {
            if (patientId == null)
            {
                throw new ValidationException("PatientId is null", "PatientId");
            }

            Patient patient = Database.Patients.Get(patientId.Value);

            if (patient == null)
            {
                throw new ValidationException("Patient not found", "PatientId");
            }

            return patient.MedicalCard.Equals(null) ? null : Get(patient.MedicalCard.Id);
        }

        public IEnumerable<MedicalCardDTO> GetAll() {
            var mapper = new MapperConfiguration(config => config.CreateMap<MedicalCard, MedicalCardDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<MedicalCard>, List<MedicalCardDTO>>(Database.MedicalCards.GetAll());
        }

        public void AddLastAppointmentId(int? medicalCardId, int? lastAppointmentId) {
            if (medicalCardId == null)
            {
                throw new ValidationException("MedicalCardId is null!", "MedicalCardId");
            }

            MedicalCard medicalCard = Database.MedicalCards.Get(medicalCardId.Value);

            if (medicalCard == null)
            {
                throw new ValidationException("MedicalCars with such id not found!", "MedicalCardId");
            }

            medicalCard.LastAppointmentId = lastAppointmentId ?? throw new ValidationException("LastAppointmentId is null!", "LastAppointmentId");

            Database.MedicalCards.Update(medicalCard);
            Database.Save();
        }

        public void Dispose() {
            Database.Dispose();
        }
    }
}
