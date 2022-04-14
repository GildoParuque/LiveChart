using LiveChart.Services.API;
using LiveChart.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace LiveChart
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override  void OnStartup(StartupEventArgs e)
        {
            //APICoronavirusService countryService = new APICoronavirusService();

            //var result = await countryService.GetTopCases(10);

            MainWindow mainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };

            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
