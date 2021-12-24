using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using QuickHealthy.BLL.Infrastructure;
using QuickHealthy.BLL.Interfaces;
using QuickHealthy.BLL.Services;
using QuickHealthy.DAL.Interfaces;
using QuickHealthy.DAL.Repositories;

namespace QuickHealthy.PL.WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

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

            services.AddSingleton<IPatientService, PatientService>();
            services.AddSingleton<IDoctorService, DoctorService>();
            services.AddSingleton<IMedicalCardService, MedicalCardService>();
            services.AddSingleton<IAppointmentService, AppointmentService>();
            services.AddSingleton<IOfficeService, OfficeService>();
            services.AddSingleton<IUnitOfWork>(x => new EFUnitOfWork(Configuration.GetConnectionString("QuickHealthyDatabase")));

            //inject controller into DI and adding NewtonsoftJson to format any i/o message
            services.AddControllers()
                .AddNewtonsoftJson();

            //inject swagger into DI
            services.AddSwaggerGen();

            services.AddCors();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //adding swagger into pipeline
                app.UseSwagger();
                //adding swagger UI into pipeline and spec path of the swagger.json doc
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                });
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
