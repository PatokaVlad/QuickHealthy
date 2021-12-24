using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.Models;

namespace QuickHealthy.PL.WebApp.Services
{
    public class DoctorHelperService
    {
        IDoctorService _doctorService;
        public DoctorHelperService(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        //get first name, last name and etc to insert it in view model. it will be shown in AddAnAppointment page.
        public AppointmentViewModel EnrichAppointmentWithDoctorById(int id)
        {
            var doctor = _doctorService.Get(id);

            AppointmentViewModel appointmentViewModel = new AppointmentViewModel()
            {
                DoctorFirstName = doctor.FirstName,
                DoctorLastName = doctor.LastName,
                DoctorJobPosition = doctor.JobPosition
            };

            return appointmentViewModel;
        }
        //inversion method
        public int GetFirstDoctorId(string firstName, string lastName, string jobPosition)
        {
            var doctors = _doctorService.GetAll();

            foreach (var doc in doctors)
            {
                if (doc.FirstName == firstName 
                    && doc.LastName == lastName 
                    && doc.JobPosition == jobPosition)
                {
                    return doc.Id;
                }
            }

            return default;
        }
    }
}
