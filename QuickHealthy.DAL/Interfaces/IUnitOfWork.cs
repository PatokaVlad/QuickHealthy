using QuickHealthy.DAL.Entities;
using System;

namespace QuickHealthy.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<MedicalCard> MedicalCards { get; }
        IRepository<Office> Offices { get; }
        IRepository<Patient> Patients { get; }
        IRepository<Doctor> Doctors { get; }
        IRepository<Appointment> Appointments { get; }
        void Save();
    }
}
