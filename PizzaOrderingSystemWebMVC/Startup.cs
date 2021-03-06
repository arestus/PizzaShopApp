using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PizzaOrderingSystemWebMVC.Models;
using PizzaOrderingSystemWebMVC.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaOrderingSystemWebMVC
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
            // string connection = Configuration.GetConnectionString("DefaultConnection");
            // services.AddDbContext<pizzaContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<pizzaContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:NewConnection"]);
            });
            services.AddControllersWithViews();
            services.AddScoped<IRepo<UserLoginDetail>, UserRepo>();
            services.AddScoped<IRepo<PizzaDetail>, PizzaRepo>();
            services.AddScoped<IRepo<Topping>, ToppingRepo>();
            services.AddScoped<IRepo<OrderItemDetail>, OrderItemRepo>();
            services.AddScoped<IRepo<OrderDetail>, OrderDetailsRepo>();
            services.AddScoped<IRepo<Order>, OrderRepo>();
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


            app.UseStaticFiles();

            app.UseRouting();

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
