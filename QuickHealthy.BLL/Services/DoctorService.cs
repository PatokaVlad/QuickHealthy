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
    public class DoctorService : IDoctorService
    {
        IUnitOfWork Database { get; set; }

        public DoctorService(IUnitOfWork uow) {
            Database = uow;
        }

        public void Create(DoctorDTO doctorDTO) {
            Office office = Database.Offices.Get(doctorDTO.OfficeId);
            if (office == null)
            {
                throw new ValidationException("Office not found!", "OfficeId");
            }

            Doctor doctor = new Doctor
            {
                FirstName = doctorDTO.FirstName,
                LastName = doctorDTO.LastName,
                JobPosition = doctorDTO.JobPosition,
                StartWorkTime = doctorDTO.StartWorkTime,
                EndWorkTime = doctorDTO.EndWorkTime,
                Office = office
            };

            Database.Doctors.Create(doctor);
            Database.Save();
        }

        public DoctorDTO Get(int? id) {
            if (id == null)
            {
                throw new ValidationException("Id is null", "Id");
            }

            Doctor doctor = Database.Doctors.Get(id.Value);

            if (doctor == null)
            {
                throw new ValidationException("Doctor not found", "DoctorId");
            }

            return new DoctorDTO
            {
                Id = doctor.Id,
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                JobPosition = doctor.JobPosition,
                StartWorkTime = doctor.StartWorkTime,
                EndWorkTime = doctor.EndWorkTime,
                OfficeId = doctor.Office.Id
            };
        }

        public DoctorDTO GetDoctorByOffice(int? officeId) {
            if (officeId == null)
            {
                throw new ValidationException("OfficeId is null", "OfficeId");
            }

            Office office = Database.Offices.Get(officeId.Value);

            if (office == null)
            {
                throw new ValidationException("Office not found", "OfficeId");
            }

            return office.Doctor.Equals(null) ? null : Get(office.Doctor.Id);
        }

        public IEnumerable<DoctorDTO> GetAll() {
            var mapper = new MapperConfiguration(config => config.CreateMap<Doctor, DoctorDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Doctor>, List<DoctorDTO>>(Database.Doctors.GetAll());
        }

        public void Dispose() {
            Database.Dispose();
        }
    }
}
