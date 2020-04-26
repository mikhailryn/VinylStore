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
using Microsoft.Extensions.Hosting;
using VinylStore.Models;

namespace VinylStore
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        

  
        public void ConfigureServices(IServiceCollection services)
        {

            string conString = Configuration["ConnectionString:DefaultConnection"];
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(conString));


            services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<AppDbContext>();


            services.AddScoped<IVinylRepository, VinylRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            services.AddHttpContextAccessor();
            services.AddSession();



            services.AddControllersWithViews();
            services.AddRazorPages();



            //  services.AddMvc();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default", 
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                endpoints.MapRazorPages();
            });
        }
    }
}
