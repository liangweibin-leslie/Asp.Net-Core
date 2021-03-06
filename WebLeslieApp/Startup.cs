using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Extensions.FileProviders;
using WebLeslieApp.Data;
using Microsoft.EntityFrameworkCore;
using WebLeslieApp.Repository;

namespace WebLeslieApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddMvc();
            services.AddDbContext<BookStoreContext>(options =>options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=BookStore;Integrated Security=True;"));
            services.AddControllersWithViews();
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation();
            //Uncomment this code to disable client side validations
            //    .AddViewOptions(option => 
            //{
            //    option.HtmlHelperOptions.ClientValidationEnabled = false; 
            //});
#endif       
            services.AddScoped<BookRepository, BookRepository>();
            services.AddScoped<LanguageRepository, LanguageRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context,next) => 
            //{
            //    await context.Response.WriteAsync("Hello from my first middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my first middleware Response");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my Second middleware");
            //    await next();
            //    await context.Response.WriteAsync("Hello from my Second middleware Response");
            //});

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("Hello from my Third middleware");
            //    await next();
            //});
            app.UseRouting();
            app.UseStaticFiles();
            //app.UseStaticFiles(new StaticFileOptions()
            //{
            //    FileProvider=new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"MyStaticFiles")),
            //    RequestPath="/MyStaticFiles"
            //}
            //);

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello hahahah leslie!");
            //    });
            //});
            app.UseEndpoints(endpoints =>
                {
                    endpoints.MapDefaultControllerRoute();
                    //endpoints.MapControllerRoute(
                    //    name:"Default",
                    //    pattern:"bookapp/{controller=Home}/{action=index}/{id?}");
                });

        }
    }
}
