using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestDb.Web.Services;
using System.Security.Claims;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace TestDb.Web
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
            
            // Add application services.
            services.AddTransient<IEmailSender, EmailSender>();

            services.AddMvc(
                options => options.CacheProfiles.Add("NoCache",
                new CacheProfile() { Location = ResponseCacheLocation.None, NoStore = true }))
                .AddJsonOptions(options => {
                    options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                    options.JsonSerializerOptions.PropertyNamingPolicy = null;
                });
            ;
           
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
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseRouting();
            app.UseCors();

            app.UseStaticFiles();
	        app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                Path.Combine(Directory.GetCurrentDirectory(), "SampleScripts")),
                RequestPath = "/samplescripts"
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "defaultApi",
                    pattern: "{controller}/{id?}");
            });

        }

        
    }
}
