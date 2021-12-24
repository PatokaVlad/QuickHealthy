using QuickHealthy.DAL.EF;
using QuickHealthy.DAL.Entities;
using QuickHealthy.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace QuickHealthy.DAL.Repositories
{
    class OfficeRepository : IRepository<Office>
    {
        private DataContext db;

        public OfficeRepository(DataContext dataContext) {
            this.db = dataContext;
        }

        public void Create(Office item) {
            db.Offices.Add(item);
        }

        public void Update(Office item) {
            db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id) {
            Office office = db.Offices.Find(id);
            if (office != null)
            {
                db.Offices.Remove(office);
            }
        }

        public IEnumerable<Office> Find(Func<Office, bool> predicate) {
            return db.Offices.Include(d => d.Doctor).Where(predicate).ToList();
        }

        public Office Get(int id) {
            return db.Offices.Find(id);
        }

        public IEnumerable<Office> GetAll() {
            return db.Offices.Include(d => d.Doctor);
        }
    }
}
