using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[XmlRoot(ElementName = "weather")]
public partial class WeatherXml
{

    [XmlAttribute(AttributeName = "number")]
    public int Number { get; set; }

    [XmlAttribute(AttributeName = "value")]
    public string Value { get; set; }

    [XmlAttribute(AttributeName = "icon")]
    public string Icon { get; set; }

}

public interface IBaseModel
{
    public int id { get; set; }
}
public interface IWeather : IBaseModel
{
     string icon { get; set; }
}

public class Weather : IWeather
{
    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonProperty("main")]
    [JsonPropertyName("main")]
    public string main { get; set; }

    [JsonProperty("description")]
    [JsonPropertyName("description")]
    public string description { get; set; }

    [JsonProperty("icon")]
    [JsonPropertyName("icon")]
    public string icon { get; set; }

}

