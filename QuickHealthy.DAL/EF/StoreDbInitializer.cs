using QuickHealthy.DAL.Entities;
using System.Data.Entity;
using System;

namespace QuickHealthy.DAL.EF
{
    internal class StoreDbInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context) {
            context.SaveChanges();
        }
    }
}