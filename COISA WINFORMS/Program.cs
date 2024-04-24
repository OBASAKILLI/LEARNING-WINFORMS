using COISALIBRARY.Context;
using COISA_WINFORMS.Views.Login;
using COISALIBRARY.Interfaces;
using COISALIBRARY.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using COISA_WINFORMS.Views;

namespace COISA_WINFORMS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<LoginPage>());
        }
        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    string? connectionString = "Server=localhost;Database=CoisaWinFormsApp;port=3306;Uid=root;Pwd=kili100000";
                    services.AddDbContext<CoisaDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
                    services.AddTransient<IUnitOfWork, UnitOfWork>();
                   
                    services.AddTransient<LoginPage>();
                });
        }
    }
}