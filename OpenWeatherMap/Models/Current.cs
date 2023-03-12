using System.Xml.Serialization;

[XmlRoot(ElementName = "current")]
public class XmlData
{

    [XmlElement(ElementName = "city")]
    public City City { get; set; }

    [XmlElement(ElementName = "temperature")]
    public Temperature Temperature { get; set; }

    [XmlElement(ElementName = "feels_like")]
    public FeelsLike FeelsLike { get; set; }

    [XmlElement(ElementName = "humidity")]
    public Humidity Humidity { get; set; }

    [XmlElement(ElementName = "pressure")]
    public Pressure Pressure { get; set; }

    [XmlElement(ElementName = "wind")]
    public Wind Wind { get; set; }

    [XmlElement(ElementName = "clouds")]
    public CloudsNameValue Clouds { get; set; }

    [XmlElement(ElementName = "visibility")]
    public Visibility Visibility { get; set; }

    [XmlElement(ElementName = "precipitation")]
    public Precipitation Precipitation { get; set; }

    [XmlElement(ElementName = "weather")]
    public WeatherXml Weather { get; set; }

    [XmlElement(ElementName = "lastupdate")]
    public Lastupdate Lastupdate { get; set; }
}

