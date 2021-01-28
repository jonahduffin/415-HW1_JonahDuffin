using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _415_HW1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); //have to add this to UseRouting() and UseEndpoints().
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsEnvironment("Development"))
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                //add error page
            }
            app.UseNodeModules(); // Had to install a package called "Ode to Node" from NuGet to use this function. Loads modules from package.json
            // app.UseDefaultFiles(); // Have to "UseDefaultFiles" first. Order matters!
            app.UseStaticFiles();
            app.UseRouting();

            app.UseEndpoints(cfg =>
                {
                    cfg.MapControllerRoute("Default", "{controller}/{action}/{id?}", new { controller = "First", action = "Index" });
                });
        }
    }
}
