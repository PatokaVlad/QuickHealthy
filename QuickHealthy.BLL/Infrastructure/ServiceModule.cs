using Ninject.Modules;
using QuickHealthy.DAL.Interfaces;
using QuickHealthy.DAL.Repositories;

namespace QuickHealthy.BLL.Infrastructure
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;

        public ServiceModule(string connection) {
            connectionString = connection;
        }

        public override void Load() {
            Bind<IUnitOfWork>().To<EFUnitOfWork>().WithConstructorArgument(connectionString);
        }
    }
}
