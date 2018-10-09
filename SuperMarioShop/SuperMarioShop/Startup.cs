using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SuperMarioShop.Data;
using SuperMarioShop.Data.interfaces;
using SuperMarioShop.Data.mocks;
using SuperMarioShop.Data.Repositories;

namespace SuperMarioShop
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;

        public Startup(IHostingEnvironment hostingEnviroment)
        {
            _configurationRoot = new ConfigurationBuilder().SetBasePath(hostingEnviroment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Server configuration
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            // Using Mock Repositories (hard code)
            // services.AddTransient<IProductRepository, MockProductRepository>();
            // services.AddTransient<ICategoryRepository, MockCategoryRepository>();

            // We don't need to change anything in our controller because we are using 
            // interfaces to inject and dependency injection that will return 
            // the second parameter from this configuration below (real reporsitories)
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        //public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        //{
        //    if (env.IsDevelopment())
        //    {
        //        app.UseDeveloperExceptionPage();
        //    }
        //    else
        //    {
        //        app.UseExceptionHandler("/Error");
        //        app.UseHsts();
        //    }

        //    app.UseHttpsRedirection();
        //    app.UseStaticFiles();
        //    app.UseCookiePolicy();

        //    app.UseMvc(routes =>
        //    {
        //        routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
        //    });
        //}

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            // loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            // The last one is the same that code below:
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            //});

            app.UseHttpsRedirection();
            app.UseCookiePolicy();

            // Every time you run the application, this one check if the if the initial data is there or not
            DbInitializer.Seed(serviceProvider);
        }
    }
}
