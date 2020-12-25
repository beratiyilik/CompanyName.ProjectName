using AutoMapper;
using CompanyName.ProjectName.API.HealthChecks;
using CompanyName.ProjectName.Application.Interfaces;
using CompanyName.ProjectName.Application.Services;
using CompanyName.ProjectName.Common.Configuration;
using CompanyName.ProjectName.Common.Interfaces;
using CompanyName.ProjectName.Common.Repositories.Base;
using CompanyName.ProjectName.Common.Repositories;
using CompanyName.ProjectName.Infrastructure.Data;
using CompanyName.ProjectName.Infrastructure.Logging;
using CompanyName.ProjectName.Infrastructure.Repository.Base;
using CompanyName.ProjectName.Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace CompanyName.ProjectName.API
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
            /* projectname dependencies */
            this.ConfigureProjectNameServices(services);

            this.AddSwagger(services);

            this.AddCors(services);

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                /* http://localhost:5000/swagger/v1/swagger.json */
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjectName V1");
                c.RoutePrefix = string.Empty;
                // c.InjectStylesheet("/swagger-ui/custom.css");
                c.DocExpansion(DocExpansion.None);
            });
        }

        private void ConfigureProjectNameServices(IServiceCollection services)
        {
            /* Add Core Layer */
            services.Configure<ProjectNameSettings>(Configuration);

            /* Add Infrastructure Layer */
            ConfigureDatabases(services);
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<ITestParentRepository, TestParentRepository>();
            services.AddScoped<ITestChildRepository, TestChildRepository>();
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));

            /* Add Application Layer */
            services.AddScoped<ITestParentService, TestParentService>();
            services.AddScoped<ITestChildService, TestChildService>();

            /* Add Web Layer */
            services.AddAutoMapper(typeof(Startup));
            // services.AddScoped<IIndexPageService, IndexPageService>();
            // services.AddScoped<IProductPageService, ProductPageService>();
            // services.AddScoped<ICategoryPageService, CategoryPageService>();

            /* Add Miscellaneous */
            services.AddHttpContextAccessor();
            services.AddHealthChecks()
                .AddCheck<IndexPageHealthCheck>("home_page_health_check");
        }

        public void ConfigureDatabases(IServiceCollection services)
        {
            /* use in-memory database */
            services.AddDbContext<ProjectNameContext>(c =>
                c.UseInMemoryDatabase("ProjectNameConnection"));

            /* use real database */
            // services.AddDbContext<ProjectNameContext>(c =>
            //     c.UseSqlServer(Configuration.GetConnectionString("ProjectNameConnection")));
        }

        private void AddSwagger(IServiceCollection serviceCollection)
        {
            // Register the Swagger generator, defining 1 or more Swagger documents
            serviceCollection.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjectName API", Version = "v1" });
            });
            serviceCollection.AddControllers();
        }

        private void AddKsI18N(IServiceCollection serviceCollection)
        {

        }

        private void AddCors(IServiceCollection serviceCollection)
        {
            serviceCollection.AddCors(x =>
            {
                x.AddPolicy("AllowAll", builder =>
                {
                    builder.AllowCredentials()
                            .AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                });
            });
        }

        private void AddMvcCore(IServiceCollection serviceCollection)
        {

        }

        private void AddIdentity(IServiceCollection serviceCollection)
        {

        }

        private void AddAuthentication(IServiceCollection serviceCollection)
        {

        }

        private void AddAuthorization(IServiceCollection serviceCollection)
        {

        }
    }
}
