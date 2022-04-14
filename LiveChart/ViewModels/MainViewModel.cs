using LiveChart.Services;
using LiveChart.Services.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiveChart.ViewModels
{
    public class MainViewModel
    {
        public CoronavirusCountryChartViewModel CoronavirusCountriesChartViewModel { get; set; }

        public MainViewModel()
        {
            ICoronavirusCountryService coronavirusCountryService = new APICoronavirusService();
            CoronavirusCountriesChartViewModel =  CoronavirusCountryChartViewModel.LoadViewModel(coronavirusCountryService);
        }
    }
}
