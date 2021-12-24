using QuickHealthy.DAL.Entities;
using System.Data.Entity;

namespace QuickHealthy.DAL.EF
{
    public class DataContext : DbContext
    {
        public DbSet<Office> Offices { get; set; }
        public DbSet<MedicalCard> MedicalCards { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        static DataContext() {
            Database.SetInitializer<DataContext>(new StoreDbInitializer());
        }

        public DataContext(string connectionString) : base(connectionString) { }
    }
}
