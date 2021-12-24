using Ninject.Modules;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.BLL.Services;

namespace QuickHealthy.PL.Util
{
    class AppointmentModule : NinjectModule
    {
        public override void Load() {
            Bind<IAppointmentService>().To<AppointmentService>();
        }
    }
}
