using QuickHealthy.DAL.EF;
using QuickHealthy.DAL.Entities;
using QuickHealthy.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuickHealthy.DAL.Repositories
{
    class AppointmentRepository : IRepository<Appointment>
    {
        private DataContext db;

        public AppointmentRepository(DataContext dataContext) {
            this.db = dataContext;
        }

        public void Create(Appointment item) {
            db.Appointments.Add(item);
        }

        public void Update(Appointment item) {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id) {
            Appointment appointment = db.Appointments.Find(id);
            if (appointment != null)
            {
                db.Appointments.Remove(appointment);
            }
        }

        public IEnumerable<Appointment> Find(Func<Appointment, bool> predicate) {
            return db.Appointments.Include(d => d.Doctor).
                                Include(m => m.MedicalCard).
                                Where(predicate).ToList();
        }

        public Appointment Get(int id) {
            return db.Appointments.Include(d => d.Doctor).
                Include(m => m.MedicalCard).SingleOrDefault(a => a.Id == id);
        }

        public IEnumerable<Appointment> GetAll() {
            return db.Appointments.Include(d => d.Doctor).
                Include(m => m.MedicalCard);
        }
    }
}
