using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MVVM_template.Home;
using MVVM_template.Main;
using System;
using System.Windows;

namespace MVVM_template
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration ConfigurationProvider { get; private set; }

        public App()
        {
            ServiceProvider = createServiceProvider(ConfigurationProvider);
        }

        private IServiceProvider createServiceProvider(IConfiguration configuration)
        {
            IServiceCollection serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IMainViewModel, MainViewModel>();
            serviceCollection.AddTransient<IHomeViewModel, HomeViewModel>();

            return serviceCollection.BuildServiceProvider();
        }
    }
}
