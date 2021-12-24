using Ninject.Modules;
using System.Net.Http;

namespace QuickHealthy.Client.WinForms.Util
{
    class QuickHealthyClientModule : NinjectModule
    {
        public override void Load()
        {
            Bind<HttpClient>().To<HttpClient>();
        }
    }
}
