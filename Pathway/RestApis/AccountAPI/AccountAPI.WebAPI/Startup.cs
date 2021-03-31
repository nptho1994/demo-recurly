using AccountAPI.Core.Handlers;
using AccountAPI.Core.Interfaces;
using AccountAPI.Core.Interfaces.Handlers;
using AccountAPI.Core.Interfaces.ThirdParties;
using AccountAPI.Infrastructures;
using AccountAPI.Infrastructures.Repositories;
using AccountAPI.Infrastructures.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AccountAPI.WebAPI
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
            services.AddControllers()
                .AddXmlSerializerFormatters();

            // Infrastructure
            services.AddInfrastructure(Configuration);

            // Services
            services.AddTransient<IRecurlyService, RecurlyService>();

            // Handlers
            services.AddTransient<IAccountNotificationHandler, AccountNotificationHandler>();
            services.AddTransient<IAccountRepository, AccountRepository>();

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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
