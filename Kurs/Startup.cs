using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kurs.Data.Interfaces;
using Kurs.Data.Mocks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Kurs.Data;
using Microsoft.EntityFrameworkCore;
using Kurs.Data.Repository;

namespace Kurs
{
    public class Startup
    {
        private IConfigurationRoot _conf;

        public Startup(IHostEnvironment hostEnv) 
        {
            _conf = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("db_settings.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IThemes, ThemeRepository>();
            services.AddTransient<IThemsLevel, MockLevel>();
            services.AddMvc();
            services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_conf.GetConnectionString("DefaultConnection")) );

            services.AddControllersWithViews(mvcOtions =>
            {
                mvcOtions.EnableEndpointRouting = false;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute(
            //        name: "default",
            //        template: "{controller=Home}/{action=Index}/{id?}");
            //});
            app.UseMvcWithDefaultRoute();

            DBObjects.Initial(app);
        }
    }
}
