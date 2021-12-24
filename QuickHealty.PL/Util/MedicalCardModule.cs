using Ninject.Modules;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.BLL.Services;

namespace QuickHealthy.PL.Util
{
    public class MedicalCardModule : NinjectModule
    {
        public override void Load() {
            Bind<IMedicalCardService>().To<MedicalCardService>();
        }
    }
}
