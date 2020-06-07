using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Solidariedade.CrossCutting;

namespace Solidariedade.MVC
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

            services.AddAuthentication(options =>
                {
                    options.DefaultScheme = "cookie";
                    options.DefaultChallengeScheme = "oidc";
                }).AddCookie("cookie")
                 .AddOpenIdConnect("oidc", options =>
                        {
                            options.Authority = "http://localhost:5000/";
                            options.ClientId = "SolidariedadeApp";
                            options.ClientSecret = "G7kj@as";
                            options.SignInScheme = "cookie";
                            options.RequireHttpsMetadata = false;
                            options.ResponseType = "code id_token";


                            options.SaveTokens = true;
                            options.GetClaimsFromUserInfoEndpoint = true;

                            options.Scope.Add("email");
                            options.Scope.Add("offline_access");
                            options.ClaimActions.MapJsonKey("website", "website");
                        });
            services.AddDbContext();
            services.AddSolidariedadeServices();
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
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
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
