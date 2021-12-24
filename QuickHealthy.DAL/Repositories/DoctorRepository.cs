using QuickHealthy.DAL.EF;
using QuickHealthy.DAL.Entities;
using QuickHealthy.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuickHealthy.DAL.Repositories
{
    class DoctorRepository : IRepository<Doctor>
    {
        private DataContext db;

        public DoctorRepository(DataContext dataContext) {
            this.db = dataContext;
        }

        public void Create(Doctor item) {
            db.Doctors.Add(item);
        }

        public void Update(Doctor item) {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id) {
            Doctor doctor = db.Doctors.Find(id);
            if (doctor != null)
            {
                db.Doctors.Remove(doctor);
            }
        }

        public IEnumerable<Doctor> Find(Func<Doctor, bool> predicate) {
            return db.Doctors.Include(o => o.Office).Where(predicate).ToList();
        }

        public Doctor Get(int id) {
            return db.Doctors.Include(o => o.Office).FirstOrDefault(d => d.Id == id);
        }

        public IEnumerable<Doctor> GetAll() {
            return db.Doctors.Include(o => o.Office);
        }
    }
}
