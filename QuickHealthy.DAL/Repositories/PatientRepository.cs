using QuickHealthy.DAL.EF;
using QuickHealthy.DAL.Entities;
using QuickHealthy.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuickHealthy.DAL.Repositories
{
    class PatientRepository : IRepository<Patient>
    {
        private DataContext db;

        public PatientRepository(DataContext dataContext) {
            this.db = dataContext;
        }

        public void Create(Patient item) {
            db.Patients.Add(item);
        }

        public void Update(Patient item) {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id) {
            Patient patient = db.Patients.Find(id);
            if (patient != null)
            {
                db.Patients.Remove(patient);
            }
        }

        public IEnumerable<Patient> Find(Func<Patient, bool> predicate) {
            return db.Patients.Include(m => m.MedicalCard).
                            Where(predicate).ToList();
        }

        public Patient Get(int id) {
            return db.Patients.Include(p => p.MedicalCard)
                .FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Patient> GetAll() {
            return db.Patients.Include(m => m.MedicalCard);
        }
    }
}
