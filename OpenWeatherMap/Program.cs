using log4net;
using log4net.Config;
using OpenWeatherMap.Contracts;
using OpenWeatherMap.Services;

class Program
{
    private static readonly ILog log = LogManager.GetLogger(typeof(Program));
    static async Task Main(string[] args)
    {
        XmlConfigurator.Configure(new FileInfo("log4net.config"));

        WeatherService weatherService = new WeatherService();
        string lng = "51.5074";
        string lat = "0.1278";
        string city = "Manila";

        log.Info("test");

        var weatherJson = await weatherService.GetWeatherAsync<JsonData>(lng, lat, WeatherService.ResponseType.Json);

        Console.WriteLine($"weather in {lng}, {lat} : {weatherJson.main.temp}");

        var weatherXml = await weatherService.GetWeatherAsync<XmlData>("Manila", WeatherService.ResponseType.Xml);

        Console.WriteLine($"weather in {city} : {weatherXml.Weather.Value}");
        Console.ReadLine();

    }


}

