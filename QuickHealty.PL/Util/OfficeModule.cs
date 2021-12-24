using Ninject.Modules;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.BLL.Services;

namespace QuickHealthy.PL.Util
{
    public class OfficeModule : NinjectModule
    {
        public override void Load() {
            Bind<IOfficeService>().To<OfficeService>();
        }
    }
}
