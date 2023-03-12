using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

[XmlRoot(ElementName = "wind")]
public class Wind
{

    [XmlElement(ElementName = "speed")]
    public Speed Speed { get; set; }

    [XmlElement(ElementName = "gusts")]
    public object Gusts { get; set; }

    [XmlElement(ElementName = "direction")]
    public Direction Direction { get; set; }
}

public class WindJson
{
    [JsonProperty("speed")]
    [JsonPropertyName("speed")]
    public double speed { get; set; }

    [JsonProperty("deg")]
    [JsonPropertyName("deg")]
    public double deg { get; set; }
}