using LiveChart.Models;
using LiveChart.Services;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveChart.ViewModels
{
    public class CoronavirusCountryChartViewModel
    {
        private const int AMOUNT_OF_COUNTRIES = 10;
        private readonly ICoronavirusCountryService _coronavirusCountryService;

        public ChartValues<int> CoronavirusCountryCaseCount { get; set; }

        public string[] CoronavirusCountryNames { get; set; }

        public CoronavirusCountryChartViewModel(ICoronavirusCountryService coronavirusCountryService)
        {
            _coronavirusCountryService = coronavirusCountryService;

        }

        public static CoronavirusCountryChartViewModel LoadViewModel(ICoronavirusCountryService coronavirusCountryService, Action<Task> onLoaded = null)
        {
            CoronavirusCountryChartViewModel viewModel = new CoronavirusCountryChartViewModel(coronavirusCountryService);

            viewModel.Load().ContinueWith(t => onLoaded?.Invoke(t));

            return viewModel;
        }

        public async Task Load()
        {
            IEnumerable<CoronavirusCountry> countries = await _coronavirusCountryService.GetTopCases(AMOUNT_OF_COUNTRIES);

            CoronavirusCountryCaseCount = new ChartValues<int>(countries.Select(c => c.CaseCount));
            CoronavirusCountryNames = countries.Select(c => c.CountryName).ToArray();
        }
    }
}
