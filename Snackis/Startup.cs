using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Snackis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System;

namespace Snackis
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizeFolder("/Admin");
            });
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential 
                // cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                // requires using Microsoft.AspNetCore.Http;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            //services.AddDbContext<CategoriesDBContext>(options =>
            //options.UseSqlServer(
            //    Configuration.GetConnectionString("SnackisContextConnection")));

            //services.AddDbContext<SubCatDBContext>(options =>
            //options.UseSqlServer(
            //    Configuration.GetConnectionString("SnackisContextConnection")));

            //services.AddDbContext<PostsDBContext>(options =>
            //options.UseSqlServer(
            //    Configuration.GetConnectionString("SnackisContextConnection")));

            //services.AddDbContext<ReportDBContext>(options =>
            //options.UseSqlServer(
            //Configuration.GetConnectionString("SnackisContextConnection")));

            services.AddDbContext<SnackisDBContext>(options =>
            options.UseSqlServer(
            Configuration.GetConnectionString("SnackisContextConnection")));

            services.AddHttpClient<Gateway.InspoQuoteGateway>();
            services.AddScoped<Models.IInspoQuoteGateway, Gateway.InspoQuoteGateway>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseRouting();


            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });

            serviceProvider.GetService<SnackisContext>().Database.EnsureCreated();
        }
    }
}
