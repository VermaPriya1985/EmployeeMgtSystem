using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

using EmployeeSystem;
using EmployeeSystem.Storage;
using EmployeeSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
namespace EmploymentSystemMvc
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
            services.AddControllersWithViews();
            services.AddRazorPages();
            // Dependency Injection
            // var bookStorage = new BookStorageList();
            // var patronStorage = new PatronStorageList();
            // var loanStorage = new LoanStorageList();
            // "DefaultDB": "Host=suleiman.db.elephantsql.com;Port=5432;Database=okmpimxz;Username=okmpimxz;Password=[REDACTED];"

            string connectionString = Configuration.GetConnectionString("DefaultDB");
            services.AddDbContext<ApplicationContext>(options => options.UseNpgsql(connectionString, b => b.MigrationsAssembly("EmploymentSystemMvc")));
            
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddEntityFrameworkStores<ApplicationContext>();

            services.AddScoped<IStoreEmployee, EmployeeStorageEF>();
            services.AddScoped<IStoreHoliday, HolidayStorageEF>();
            services.AddScoped<IStoreLeave, LeaveStorageEF>();
            services.AddScoped<IStoreConcern, ConcernStorageEF>();
            services.AddScoped<EmployeeManagement>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope()) {
                using (var context = serviceScope.ServiceProvider.GetService<ApplicationContext>()) {
                    context.Database.Migrate();
                }
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
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
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                    // endpoints.MapRazorPages();
            });
        }
    }
}
