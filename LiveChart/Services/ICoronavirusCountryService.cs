using LiveChart.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LiveChart.Services
{
    public interface ICoronavirusCountryService
    {
        Task<IEnumerable<CoronavirusCountry>> GetTopCases(int amountCountry);
    }
}
