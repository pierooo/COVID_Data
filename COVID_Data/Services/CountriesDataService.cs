using COVID_Data.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COVID_Data.Services
{
    public class CountriesDataService : ICountriesDataService
    {
        private readonly IHttpService httpService;
        public CountriesDataService(IHttpService httpService)
        {
            this.httpService = httpService;
        }

        public async Task<List<CountryData>> GetTwentyMostConfirmed()
        {
            var result = await httpService.Get<Root>("/summary");
            return result.Countries.OrderByDescending(x => x.TotalConfirmed).Take(20).ToList();
        }
    }
}
