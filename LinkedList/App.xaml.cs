using LinkedList.Services;
using LinkedList.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace LinkedList
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static bool IsDesignTime { get; private set; } = true;

        private static IHost? host;
        public static IHost Host => host
            ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();

        public static IServiceProvider Services = Host.Services;



        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services)
            => services
            .AddServices()
            .AddViewModels()
            ;

        protected override async void OnStartup(StartupEventArgs e)
        {
            IsDesignTime = false;
            var host = Host;
            base.OnStartup(e);
            await host.StartAsync();

        }

        protected override async void OnExit(ExitEventArgs e)
        {

            using var host = Host;
            base.OnExit(e);
            await Host.StopAsync();

        }







    }
}
