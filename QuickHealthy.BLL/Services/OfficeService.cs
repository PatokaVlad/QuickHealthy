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
    public class OfficeService : IOfficeService
    {
        IUnitOfWork Database { get; set; }

        public OfficeService(IUnitOfWork uow) {
            Database = uow;
        }

        public void Create(OfficeDTO officeDTO) {
            Doctor doctor = officeDTO.DoctorId.HasValue ? Database.Doctors.Get(officeDTO.DoctorId.Value) : null;

            Office office = new Office
            {
                Description = officeDTO.Description,
                Doctor = doctor
            };

            Database.Offices.Create(office);
            Database.Save();
        }

        public OfficeDTO Get(int? id) {
            if (id == null)
            {
                throw new ValidationException("Id is null", "Id");
            }

            Office office = Database.Offices.Get(id.Value);

            if (office == null)
            {
                throw new ValidationException("Office not found", "OfficeId");
            }

            return new OfficeDTO
            {
                Id = office.Id,
                Description = office.Description,
                DoctorId = office.Doctor.Id
            };
        }

        public OfficeDTO GetOfficeByDoctor(int? doctorId) {
            if (doctorId == null)
            {
                throw new ValidationException("DoctorId is null", "DoctorId");
            }

            Office office = Database.Offices.Get(doctorId.Value);

            if (office == null)
            {
                throw new ValidationException("Office not found", "DoctorId");
            }

            return Get(office.Id);
        }

        public IEnumerable<OfficeDTO> GetAll() {
            var mapper = new MapperConfiguration(config => config.CreateMap<Office, OfficeDTO>()).CreateMapper();
            return mapper.Map<IEnumerable<Office>, List<OfficeDTO>>(Database.Offices.GetAll());
        }

        public void Dispose() {
            Database.Dispose();
        }
    }
}
