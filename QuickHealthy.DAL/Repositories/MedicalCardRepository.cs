using QuickHealthy.DAL.EF;
using QuickHealthy.DAL.Entities;
using QuickHealthy.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuickHealthy.DAL.Repositories
{
    class MedicalCardRepository : IRepository<MedicalCard>
    {
        private DataContext db;

        public MedicalCardRepository(DataContext dataContext) {
            this.db = dataContext;
        }

        public void Create(MedicalCard item) {
            db.MedicalCards.Add(item);
        }

        public void Update(MedicalCard item) {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id) {
            MedicalCard medicalCard = db.MedicalCards.Find(id);
            if (medicalCard != null)
            {
                db.MedicalCards.Remove(medicalCard);
            }
        }

        public IEnumerable<MedicalCard> Find(Func<MedicalCard, bool> predicate) {
            return db.MedicalCards.Include(p => p.Patient).
                                Where(predicate).ToList();
        }

        public MedicalCard Get(int id) {
            return db.MedicalCards.Include(p => p.Patient)
                .FirstOrDefault(i => i.Id == id);
        }

        public IEnumerable<MedicalCard> GetAll() {
            return db.MedicalCards.Include(p => p.Patient);
        }
    }
}
