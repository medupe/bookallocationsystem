using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bookallocationsystem.Data.Allocation;
using bookallocationsystem.Data.Books;
using bookallocationsystem.Data.Learners;
using bookallocationsystem.Data.Schools;
using Bookallocationsystem.Data;
using Bookallocationsystem.Data.Accounts;
using Bookallocationsystem.Models.AppUsers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace bookallocationsystem
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
            services.AddScoped<IAppAccountRepository, AppAccountRepository>();
            services.AddScoped<ISchoolRepository, SchoolRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<ILearnerRepository, LearnerRepository>();
            services.AddScoped<IAllocateRepository, AllocateRepository>();
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.User.RequireUniqueEmail = true;

            }).AddEntityFrameworkStores<IdentityAppContext>();
            services.AddDbContext<IdentityAppContext>(cfg =>
            {

                cfg.UseSqlServer(Configuration.GetConnectionString("appdb"));


            });
            services.AddAuthentication()
         .AddCookie("user_by_cookie", options =>
         {
             options.LoginPath = "/Home/Index/";
         });



            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseAuthentication();
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
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Dashboard}/{action=Index}/{id?}");
            });
        }
    }
}
