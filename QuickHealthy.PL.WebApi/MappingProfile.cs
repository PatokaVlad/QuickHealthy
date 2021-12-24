using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.PL.Models;

namespace QuickHealthy.PL.WebApi
{
    public class MappingProfile : Profile
    {
        //just a mapping profile for automapper. instantce of this class creates in startup
        public MappingProfile()
        {
            CreateMap<DoctorDTO, DoctorViewModel>();
            CreateMap<DoctorViewModel, DoctorDTO>();
            CreateMap<AppointmentDTO, AppointmentViewModel>();
            CreateMap<AppointmentViewModel, AppointmentDTO>();
            CreateMap<OfficeDTO, OfficeViewModel>();
            CreateMap<OfficeViewModel, OfficeDTO>();
            CreateMap<PatientDTO, PatientViewModel>();
            CreateMap<PatientViewModel, PatientDTO>();
            CreateMap<MedicalCardDTO, MedicalCardViewModel>();
            CreateMap<MedicalCardViewModel, MedicalCardDTO>();
        }
    }
}
