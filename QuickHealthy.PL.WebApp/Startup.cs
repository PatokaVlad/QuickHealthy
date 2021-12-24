using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.BLL.Services;
using QuickHealthy.DAL.Interfaces;
using QuickHealthy.DAL.Repositories;
using QuickHealthy.PL.WebApi;
using QuickHealthy.PL.WebApp.Services;

namespace QuickHealthy.PL.WebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //add mapper in DI and spec mapping profile
            #region mapper
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            #endregion

            //just injection into DI
            services.AddSingleton<IPatientService, PatientService>();
            services.AddSingleton<IDoctorService, DoctorService>();
            services.AddSingleton<IMedicalCardService, MedicalCardService>();
            services.AddSingleton<IAppointmentService, AppointmentService>();
            services.AddSingleton<IOfficeService, OfficeService>();
            services.AddSingleton<IUnitOfWork>(x => new EFUnitOfWork(Configuration.GetConnectionString("QuickHealthyDatabase")));
            services.AddSingleton<DoctorHelperService>();

            //add controllers and razors
            services.AddControllersWithViews();
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
