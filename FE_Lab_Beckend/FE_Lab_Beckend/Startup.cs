using FE_Lab_Beckend.Data;
using FE_Lab_Beckend.Data.Interface;
using FE_Lab_Beckend.Data.Models;
using FE_Lab_Beckend.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;

namespace FE_Lab_Beckend
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            Configuration = configuration;

            var builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true);


            Configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSwaggerGen(opt =>
            {
                opt.SwaggerDoc("v1", new Info { Title = "FE v1", Version = "v1" });
            });

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IExamService, ExamService>();
            services.AddScoped<IStudentService, StudentService>();

            services.AddCors(options =>
            {
                options.AddPolicy("AllowAllHeaders",
                      builder =>
                      {
                          builder.AllowAnyOrigin()
                                 .AllowAnyHeader()
                                 .AllowAnyMethod()
                                 .AllowCredentials();
                      });
            });

            services.AddMvc();
        }

        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }

            app.UseCors(options => options.WithOrigins("http://felab.apphb.com/")
            .AllowAnyMethod());

            //app.UseCors("AllowAllHeaders");

            /*app.UseCors(opt => opt.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()
                .AllowAnyOrigin());*/

            app.UseStaticFiles();

            app.UseSwagger();

            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "FE v1");
            });


            app.UseMvc();
        }
    }
}
