using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using CarAPI.Services;

namespace CarAPI
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = "Server=localhost;Database=cars; User Id=sa;Password=passwordPwd123";
            services    
                .AddDbContext<CarsDBContext>(o =>
                    o.UseSqlServer(connectionString));
            services
                .AddMvc();
        }

        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env,
            CarsDBContext carsDBContext)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            carsDBContext.CreateSeedData();
            app.UseMvc();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("C# can't find anything");
            });
        }
    }
}