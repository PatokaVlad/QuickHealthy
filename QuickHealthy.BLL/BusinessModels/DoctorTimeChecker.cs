using QuickHealthy.BLL.DTO;
using QuickHealthy.BLL.Services;
using QuickHealthy.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickHealthy.BLL.BusinessModels
{
    public class DoctorTimeChecker
    {
        IUnitOfWork Database { get; set; }

        DoctorService _doctorService;
        AppointmentService _appointmentService;

        AppointmentDTO _appointment;
        DoctorDTO _doctor;

        IEnumerable<AppointmentDTO> _appointments;



        public DoctorTimeChecker(IUnitOfWork uow, AppointmentDTO appointment)  {
            Database = uow;

            _doctorService = new DoctorService(Database);
            _appointmentService = new AppointmentService(Database);

            _appointment = appointment;

            _doctor = _doctorService.Get(_appointment.DoctorId);
            _appointments = _appointmentService.GetAppointmentsByDoctror(_appointment.DoctorId);
        }

        public bool DoctorIsBusy() {

            if (_appointment.Time.TimeOfDay < _doctor.StartWorkTime.TimeOfDay ||
                _appointment.Time.TimeOfDay > _doctor.EndWorkTime.TimeOfDay)
            {
                return true;
            }

            foreach (var item in _appointments)
            {
                if (item.Date == _appointment.Date)
                {
                    TimeSpan interval = _appointment.Time.TimeOfDay - item.Time.TimeOfDay;

                    if (Math.Abs(interval.TotalMinutes) < 30)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
