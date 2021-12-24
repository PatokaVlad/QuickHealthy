using AutoMapper;
using QuickHealthy.BLL.DTO;
using QuickHealthy.PL.Models;
using QuickHealthy.PL.WebApp.Models;

namespace QuickHealthy.PL.WebApi
{
    public class MappingProfile : Profile
    {
        //just a mapping profile
        public MappingProfile()
        {
            CreateMap<DoctorDTO, DoctorViewModel>();
            CreateMap<DoctorViewModel, DoctorDTO>();
            //it will convert DoctorId to string and DoctorFirstName
            CreateMap<AppointmentDTO, AppointmentViewModel>()
                .ForMember(dest => dest.DoctorFirstName, opt => opt.MapFrom(src => src.DoctorId.ToString()));
            //inversion
            CreateMap<AppointmentViewModel, AppointmentDTO>()
                .ForMember(dest => dest.DoctorId, opt => opt.MapFrom(src => int.Parse(src.DoctorFirstName))); ;
            CreateMap<OfficeDTO, OfficeViewModel>();
            CreateMap<OfficeViewModel, OfficeDTO>();
            CreateMap<PatientDTO, PatientViewModel>();
            CreateMap<PatientViewModel, PatientDTO>();
            CreateMap<MedicalCardDTO, MedicalCardViewModel>();
            CreateMap<MedicalCardViewModel, MedicalCardDTO>();
            CreateMap<PatientRegisterViewModel, PatientDTO>();
            CreateMap<PatientDTO, PatientRegisterViewModel>();
        }
    }
}
