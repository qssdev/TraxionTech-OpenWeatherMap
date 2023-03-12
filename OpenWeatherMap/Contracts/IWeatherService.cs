using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OpenWeatherMap.Services.WeatherService;

namespace OpenWeatherMap.Contracts
{
    internal interface IWeatherService
    {
        Task<T> GetWeatherAsync<T>(string latitude, string longhitude, ResponseType mode);
        Task<T> GetWeatherAsync<T>(string city, ResponseType mode);
    }
}
