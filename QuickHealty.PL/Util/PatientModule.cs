using Ninject.Modules;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.BLL.Services;

namespace QuickHealthy.PL.Util
{
    public class PatientModule : NinjectModule
    {
        public override void Load() {
            Bind<IPatientService>().To<PatientService>();
        }
    }
}
