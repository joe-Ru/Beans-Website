using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Database_Design.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
namespace Database_Design
{
    public class Startup
    {
        IConfigurationRoot Configuration;
        public Startup(IWebHostEnvironment env)
        {
            Configuration = new ConfigurationBuilder().SetBasePath(env.ContentRootPath).AddJsonFile("appsettings.json").Build();
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddTransient<IProductRepository, EFProductRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false).AddNewtonsoftJson(); services.AddMemoryCache(); services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
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
            app.UseStatusCodePages();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            app.UseMvcWithDefaultRoute();

            app.UseAuthorization();

            /* app.UseEndpoints(endpoints =>
             {
                 endpoints.MapControllerRoute(
                     name: "default",
                     pattern: "{controller=Home}/{action=Index}/{id?}");
             });*/
            app.UseMvc(routes =>
            {
                routes.MapRoute(name: null, template: "{category}/Page{page:int}", defaults: new { controller = "Product", action = "List"});
                routes.MapRoute(name: null, template: "Page{page:int}", defaults: new { controller = "Product", action = "List", page = 1 });
                routes.MapRoute(name: null, template: "Page{page:int}", defaults: new { controller = "UploadFile", action = "getfile", page = 2 });
                routes.MapRoute(name: null, template: "{category}", defaults: new { controller = "Product", action = "List", page = 1 });
                routes.MapRoute(name: null, template: "", defaults: new { controller = "Product", action = "List" , page = 1});
                routes.MapRoute(name: null, template: "{controller}/{action}/{id?}");
                //routes.MapRoute(name: "default", template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
