using Ninject;
using Ninject.Modules;
using Ninject.Web.Mvc;
using QuickHealthy.BLL.Infrastructure;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.PL.Util;
using QuickHealthy.PL.Views;
using System;
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

            NinjectModule appointmentModule = new AppointmentModule();
            NinjectModule patientModule = new PatientModule();
            NinjectModule doctorModule = new DoctorModule();
            NinjectModule medicalCardModule = new MedicalCardModule();
            NinjectModule officeModule = new OfficeModule();

            NinjectModule serviceModule = new ServiceModule("QuickHealthyDatabase");
            var kernel = new StandardKernel(appointmentModule, patientModule, doctorModule, medicalCardModule, officeModule, serviceModule);
            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));

            var loginPanel = new LogInPanel(kernel.Get<IPatientService>(), kernel.Get<IAppointmentService>(), kernel.Get<IMedicalCardService>(),
                                            kernel.Get<IOfficeService>(), kernel.Get<IDoctorService>());

            Application.Run(loginPanel);
        }
    }
}
