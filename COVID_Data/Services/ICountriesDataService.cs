using COVID_Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace COVID_Data.Services
{
    public interface ICountriesDataService
    {
        public Task<List<CountryData>> GetTwentyMostConfirmed();
    }
}
