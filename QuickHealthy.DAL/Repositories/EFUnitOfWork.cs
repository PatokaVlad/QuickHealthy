using QuickHealthy.DAL.EF;
using QuickHealthy.DAL.Entities;
using QuickHealthy.DAL.Interfaces;
using System;

namespace QuickHealthy.DAL.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private DataContext db;

        private MedicalCardRepository medicalCardRepository;
        private OfficeRepository officeRepository;
        private DoctorRepository doctorRepository;
        private PatientRepository patientRepository;
        private AppointmentRepository appointmentRepository;

        private bool disposed = false;

        public EFUnitOfWork(string connectionString) {
            db = new DataContext(connectionString);
        }

        public IRepository<MedicalCard> MedicalCards {
            get {
                if (medicalCardRepository == null)
                {
                    medicalCardRepository = new MedicalCardRepository(db);
                }

                return medicalCardRepository;
            }
        }

        public IRepository<Office> Offices {
            get {
                if (officeRepository == null)
                {
                    officeRepository = new OfficeRepository(db);
                }

                return officeRepository;
            }
        }

        public IRepository<Patient> Patients {
            get {
                if (patientRepository == null)
                {
                    patientRepository = new PatientRepository(db);
                }

                return patientRepository;
            }
        }
        public IRepository<Doctor> Doctors {
            get {
                if (doctorRepository == null)
                {
                    doctorRepository = new DoctorRepository(db);
                }

                return doctorRepository;
            }
        }

        public IRepository<Appointment> Appointments {
            get {
                if (appointmentRepository == null)
                {
                    appointmentRepository = new AppointmentRepository(db);
                }

                return appointmentRepository;
            }
        }

        public void Save() {
            db.SaveChanges();
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing) {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
    }
}
