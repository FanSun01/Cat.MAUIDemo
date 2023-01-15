using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cat.MauiDemo.ViewModels;

namespace Cat.MauiDemo
{
    public class ServiceLocator
    {
        private IServiceProvider _serviceProvider;

        public MainPageViewModel MainPageViewModel => _serviceProvider.GetService<MainPageViewModel>();

        public ServiceLocator()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<MainPageViewModel>();
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }
    }
}
