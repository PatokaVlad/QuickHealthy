using Ninject.Modules;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.BLL.Services;

namespace QuickHealthy.PL.Util
{
    class DoctorModule : NinjectModule
    {
        public override void Load() {
            Bind<IDoctorService>().To<DoctorService>();
        }
    }
}
