
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[XmlRoot(ElementName = "coord")]
public class Coord
{
    [JsonProperty("lon")]
    [JsonPropertyName("lon")]
    [XmlAttribute(AttributeName = "lon")]
    public double Lon { get; set; }

    [JsonProperty("lat")]
    [JsonPropertyName("lat")]
    [XmlAttribute(AttributeName = "lat")]
    public double Lat { get; set; }
}