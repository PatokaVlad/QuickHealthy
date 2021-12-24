using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using QuickHealthy.BLL.Infrastructure;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.Client.WinForms.ApiClient;
using QuickHealthy.Client.WinForms.Util;
using QuickHealthy.PL.Views;
using System;
using System.Net.Http;
using System.Web.Mvc;
using System.Windows.Forms;

namespace QuickHealty.PL2
{
    static class Program
    {
        [STAThread]
        static void Main() {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            NinjectModule clientModule = new QuickHealthyClientModule(); 
            NinjectModule serviceModule = new ServiceModule("QuickHealthyDatabase");

            var kernel = new StandardKernel(serviceModule, clientModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));

            var loginPanel = new LogInPanel(kernel.Get<QuickHealthyClient>());

            Application.Run(loginPanel);
        }
    }
}
