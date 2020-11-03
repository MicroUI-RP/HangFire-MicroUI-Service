namespace HangFire_MicroUI_Service.Web
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using HangFire_MicroUI_Service.DomainService.HashService;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.HttpsPolicy;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Hosting;
    using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
    using Hangfire;
    using HangFire_MicroUI_Service.Web.Models;
    using Hangfire.SqlServer;
    using System.Diagnostics;

    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // Add Hangfire services.
            services.AddHangfire(configuration => configuration
                                                  .SetDataCompatibilityLevel(CompatibilityLevel.Version_170)
                                                  .UseSimpleAssemblyNameTypeSerializer()
                                                  .UseRecommendedSerializerSettings()
                                                  .UseSqlServerStorage(Configuration.GetConnectionString("HangFirePoCCOnnectionString"),
                                                                       new SqlServerStorageOptions
                                                                       {
                                                                           CommandBatchMaxTimeout = TimeSpan.FromMinutes(5),
                                                                           SlidingInvisibilityTimeout = TimeSpan.FromMinutes(5),
                                                                           QueuePollInterval = TimeSpan.Zero,
                                                                           UseRecommendedIsolationLevel = true,
                                                                           DisableGlobalLocks = true
                                                                       }));

            // Add the processing server as IHostedService
            services.AddHangfireServer(options =>
            {
                options.WorkerCount = Environment.ProcessorCount * 5;
                /*queue are used for priortising jobs. 
                When using SQL as backend - alphanumeric order is maintained and not array index*/
                options.Queues = new[] { "alpha", "beta", "default" };
                options.HeartbeatInterval = new System.TimeSpan(0, 1, 0);
                options.ServerCheckInterval = new System.TimeSpan(0, 1, 0);
                options.SchedulePollingInterval = new System.TimeSpan(0, 1, 0);

            });

            services.AddScoped<IHashService, HashService>();
            services.AddSingleton<IPrintJob, PrintJob>();
            services.AddCors(options =>
            {
                options.AddPolicy(name: MyAllowSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("https://localhost:44310");
                                  });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
                              IWebHostEnvironment env,
                              IBackgroundJobClient backgroundJobs,
                              IRecurringJobManager recurringJobs,
                              IServiceProvider serviceProvider)
        {
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

            app.UseCors(MyAllowSpecificOrigins);

            app.UseAuthorization();

            //The following line is also optional, if you required to monitor your jobs.
            //Make sure you're adding required authentication 

            app.UseHangfireDashboard("/mydashboard", options: new DashboardOptions
            {

                DashboardTitle = "Azure Governance Portal",
                DisplayStorageConnectionString = false,
                AppPath = "https://localhost:44310/"
            });

            //backgroundJobs.Enqueue(() => Console.WriteLine("Hello world from Hangfire!"));
            //RecurringJob.RemoveIfExists("aefc3420-0078-441d-b58b-5d9ca38d55b0");
            RecurringJob.AddOrUpdate("Job 1",
                                     () => Debug.WriteLine("From Job 1"),
                                     "*/1 * * * *");

            //RecurringJob.RemoveIfExists("b045ef80-bbe8-4e3e-ae66-e96bbbe38c18");

            // RecurringJob.AddOrUpdate<IPrintJob>(
            //     "b045ef80-bbe8-4e3e-ae66-e96bbbe38c18",
            //     x => x.Print(),
            //     "*/1 * * * *",null,"alpha"
            //     );

            //recurringJobs.RemoveIfExists("Job 2");

            recurringJobs.AddOrUpdate("Job 2",
                                      () => serviceProvider.GetRequiredService<IPrintJob>().Print(),
                                      "*/1 * * * *", null, "alpha");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });                
        }
    }
}
