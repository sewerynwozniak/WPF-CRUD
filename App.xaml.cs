using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WPF_CRUD.Data;

namespace WPF_CRUD
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection service = new ServiceCollection();
            service.AddDbContext<CzytelnikDB>(option =>
            {
                option.UseSqlite("Data Source = Biblioteka.db");
            }
            );

            service.AddSingleton<MainWindow>();

            serviceProvider = service.BuildServiceProvider();
        }


        private void OnStartup(object s, StartupEventArgs e)
        {
            var mainWindow = serviceProvider.GetService<MainWindow>();
            mainWindow.Show();
        }

    }
}
