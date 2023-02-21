using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceMVC.Context;
using EcommerceMVC.Implementation.Repository;
using EcommerceMVC.Implementation.Service;
using EcommerceMVC.Implementation.services;
// using EcommerceMVC.Implementation.IRepository;
using EcommerceMVC.Interface;
using EcommerceMVC.Interface.IRepository;
using EcommerceMVC.Interface.Service;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EcommerceMVC
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
            
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IOrderedProductRepository, OrderedProductRepository>();
            services.AddScoped<IOrderedProductService, OrderedProductService>();  
            string connectionString = Configuration.GetConnectionString("ApplicationConnectionstring");
            services.AddDbContext<ApplicationContext>(x => x.UseMySQL(connectionString));
            services.AddScoped<ITransactionRepository, TransactionRepository>();
            services.AddScoped<ITrancsationService, TransationService>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
           .AddCookie(config =>
    {
        config.LoginPath = "/User/Login";
        config.LogoutPath = "/User/Login";
        config.Cookie.Name = "musty";
    });
       services.AddAuthorization();
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
                app.UseExceptionHandler("/v Home/Error");
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
            });
        }
    }
}
