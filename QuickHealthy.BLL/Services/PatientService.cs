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
    public class PatientService : IPatientService
    {
        IUnitOfWork Database { get; set; }

        public PatientService(IUnitOfWork uow) {
            Database = uow;
        }

        public void Create(PatientDTO patientDTO) {
            MedicalCard medicalCard = patientDTO.MedicalCardId.HasValue ? Database.MedicalCards.Get(patientDTO.MedicalCardId.Value) : null;

            
            Patient patient = new Patient
            {
                Username = patientDTO.Username,
                Password = patientDTO.Password,
                FirstName = patientDTO.FirstName,
                LastName = patientDTO.LastName,
                CityOfBirth = patientDTO.CityOfBirth,
                BirthDate = patientDTO.BirthDate,
                MedicalCard = medicalCard
            };

            Database.Patients.Create(patient);


            if (medicalCard == null)
            {
                Database.MedicalCards.Create(new MedicalCard() { Patient = patient });
                Database.Save();

                var newMedicalCard = Database.MedicalCards.GetAll()
                    .Where(c => c.Patient == patient).First();
                patient.MedicalCard = newMedicalCard;
            }

            Database.Save();
        }

        public PatientDTO Get(int? id) {
            if (id == null)
            {
                throw new ValidationException("Id is null", "Id");
            }

            Patient patient = Database.Patients.Get(id.Value);

            if (patient == null)
            {
                throw new ValidationException("Patient not found", "PatientId");
            }

            return new PatientDTO
            {
                Id = patient.Id,
                Username = patient.Username,
                Password = patient.Password,
                FirstName = patient.FirstName,
                LastName = patient.LastName,
                CityOfBirth = patient.CityOfBirth,
                BirthDate = patient.BirthDate,
                MedicalCardId = patient.MedicalCard.Id
            };
        }

        public PatientDTO GetPatientByMedicalCard(int? medicalCardId) {
            if (medicalCardId == null)
            {
                throw new ValidationException("MedicalCardId is null", "MedicalCardId");
            }

            Patient patient = Database.Patients.Get(medicalCardId.Value);

            if (patient == null)
            {
                throw new ValidationException("Patient not found", "MedicalCardId");
            }

            return Get(patient.Id);
        }

        public IEnumerable<PatientDTO> GetAll() {
            var mapper = new MapperConfiguration(config => config.CreateMap<Patient, PatientDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Patient>, List<PatientDTO>>(Database.Patients.GetAll());
        }

        public void Dispose() {
            Database.Dispose();
        }
    }
}
