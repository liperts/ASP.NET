using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SuperMarioShop.Data;
using SuperMarioShop.Data.interfaces;
using SuperMarioShop.Data.Interfaces;
using SuperMarioShop.Data.mocks;
using SuperMarioShop.Data.Models;
using SuperMarioShop.Data.Repositories;

namespace SuperMarioShop
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;

        public Startup(IHostingEnvironment hostingEnviroment)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnviroment.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // Server configuration
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));

            // Authentication, Identity config
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();

            // Using Mock Repositories (hard code)
            // services.AddTransient<IProductRepository, MockProductRepository>();
            // services.AddTransient<ICategoryRepository, MockCategoryRepository>();

            // We don't need to change anything in our controller because we are using 
            // interfaces to inject and dependency injection that will return 
            // the second parameter from this configuration below (real repositories)
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();

            // Provides a instance for the IHttpContextAccessor
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            // Creates an object which is associated to the request
            // If two people ask me for the ShoopingCart object are going to get different instances
            services.AddScoped(sp => ShoppingCart.GetCart(sp));
            services.AddTransient<IOrderRepository, OrderRepository>();

            services.AddMvc();
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            // loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseAuthentication();
            // app.UseMvcWithDefaultRoute();
            // The last one is the 'same' that code below:
            app.UseMvc(routes =>
            {
                // A more specific route needs to be on top
                routes.MapRoute(
                   name: "productdetails",
                   template: "Product/Details/{productId?}",
                   defaults: new { Controller = "Product", action = "Details" });

                // Filter only the requests coming from the Product controller
                // category is exactly the same name as on ProductController.cs (inside of ViewResult )
                routes.MapRoute(
                    name: "categoryFilter",
                    template: "Product/{action}/{category?}",
                    defaults: new { Controller = "Product", action = "List" });

                // id is optional -> ? means that is optional
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseHttpsRedirection();
            app.UseCookiePolicy();

            // Every time you run the application, this one check if the initial data is there or not
            DbInitializer.Seed(serviceProvider);
        }
    }
}
