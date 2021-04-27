using LIMSBlazorSever.Areas.Identity;
using LIMSBlazorSever.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LIMSBlazor.Data;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;

namespace LIMSBlazorSever
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddSingleton<WeatherForecastService>();

            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddScoped<ILabService, LabService>();
            services.AddScoped<ISampleService, SampleService>();
            services.AddScoped<ICliService, CliService>();
            services.AddScoped<ILocService, LocService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IUnitService, UnitService>();
            services.AddScoped<IInstrumTypeService, InstrumTypeService>();
            services.AddScoped<IAttrService, AttrService>();
            services.AddScoped<ISampleTypeService, SampleTypeService>();
            services.AddScoped<IAspNetUserService, AspNetUserService>();
            services.AddScoped<IAspNetRoleService, AspNetRoleService>();
            services.AddScoped<IInstrumentService, InstrumentService>();
            services.AddScoped<IAnalyticalServService, AnalyticalServService>();
            services.AddScoped<ISampleSpecService, SampleSpecService>();
            services.AddScoped<ISampleSpecAnalyticalService, SampleSpecAnalyticalService>();
            services.AddScoped<IInstrumTypeAnalyticService, InstrumTypeAnalyticService>();
            services.AddScoped<IUserRoleService, UserRoleService>();
            services.AddScoped<ISampleTypeAttrService, SampleTypeAttrService>();
            services.AddScoped<IResultService, ResultService>();
            services.AddScoped<IFinalResultService, FinalResultService>();
            services.AddScoped<ISampleAttrService, SampleAttrService>();
            services.AddScoped<ISampleAnalyticalService, SampleAnalyticalService>();
            services.AddScoped<IInstrumAnalyticService, InstrumAnalyticService>();
            services.AddScoped<IAnalyticalServiceAttrService, AnalyticalServiceAttrService>();
            services.AddScoped<IResultAttrService, ResultAttrService>();
            services.AddSingleton<WeatherForecastService>();

            // SQL database connection (name  defined in appsettings. json).
            var SqlConnectionConfiguration = new SqlConnectionConfiguration(Configuration.GetConnectionString("DefaultConnection"));
            services.AddSingleton(SqlConnectionConfiguration);

            //Optional for debugging
            services.AddServerSideBlazor(o => o.DetailedErrors = true);


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
