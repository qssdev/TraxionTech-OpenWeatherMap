using log4net;
using Newtonsoft.Json;
using OpenWeatherMap.Contracts;
using OpenWeatherMap.Services;
using System;
using System.Xml.Serialization;

namespace OpenWeatherMap.Services
{
    internal sealed class WeatherService : IWeatherService
    {
        private readonly string _apiKey = "7a53805fc2cf04b89022fea80cf46bce";
        private readonly string _apiUrl = "https://api.openweathermap.org/data/2.5/weather?";
        private static readonly ILog logger = LogManager.GetLogger(typeof(Program));

        public enum ResponseType
        {
            Json = 0,
            Xml = 1
        }

        public async Task<T> GetWeatherAsync<T>(string latitude, string longhitude, ResponseType mode)
        {
            T result;
            string url = $"{_apiUrl}lat={latitude}&lon={longhitude}&appid={_apiKey}";
            if (mode == ResponseType.Json)
            {
                result = await GetWeatherJson<T>(url);
            }
            else
            {
                result = await GetWeatherXml<T>(url);
            }
            return result;
        }

        public async Task<T> GetWeatherAsync<T>(string city, ResponseType mode)
        {
            T result;
            string url = $"{_apiUrl}q={city}&appid={_apiKey}";
            if (mode == ResponseType.Json)
            {
                result = await GetWeatherJson<T>(url);
            }
            else
            {
                result = await GetWeatherXml<T>(url);
            }
            return result;
        }

        private async Task<T> GetWeatherJson<T>(string url)
        {
            try
            {
                var response = await RequestAsync(url);

                var responseContent = await response.Content.ReadAsStringAsync();

                T weatherData = JsonConvert.DeserializeObject<T>(responseContent);

                return weatherData;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }

        }

        private async Task<T> GetWeatherXml<T>(string url)
        {
            try
            {
                var response = await RequestAsync(url);

                var stream = await response.Content.ReadAsStreamAsync();

                if (stream != null)
                {
                    var serializer = new XmlSerializer(typeof(XmlData));
                    T weatherData = (T)serializer.Deserialize(stream);
                    return weatherData;
                }

                return default(T);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                throw;
            }
        }

        private async Task<HttpResponseMessage> RequestAsync(string url)
        {
            HttpResponseMessage message = null;
            using (HttpClient client = new HttpClient())
            {
                message = await client.GetAsync(url);
            }
            return message;
        }
    }
}
