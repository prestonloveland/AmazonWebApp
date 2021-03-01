/*
 * Preston Loveland
 * Assignment 5
 * Section 1 Group 11
 * */
using AmazonWebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonWebApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            //service to connect using connection string to the databse
            services.AddDbContext<AmazonDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:AmazonConnection"]);
            });

            services.AddScoped<IAmazonRepository, EFAmazonRepository>();
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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //defining what we want the URL to look like and where we want to send the user when they hit it
                endpoints.MapControllerRoute(
                    "categorypage", //name
                    "{category}/{page:int}", //pattern
                    new { Controller = "Home", action = "Index" } //action 
                    );

                endpoints.MapControllerRoute(
                    "page",
                    "{page:int}",
                    new { Controller = "Home", action = "Index" }
                    );

                endpoints.MapControllerRoute(
                    "category",
                    "{category}",
                    new { Controller = "Home", action = "Index", page = 1 }
                    );

                endpoints.MapControllerRoute(
                   "pagination",
                    "P{page}",
                    new { Controller = "Home", action = "Index" });

                endpoints.MapDefaultControllerRoute();
            });
            //makes sure the database is populated
            SeedData.EnsurePopulated(app);
        }
    }
}
