using System.Xml.Serialization;

[XmlRoot(ElementName = "city")]
public class City
{

    [XmlElement(ElementName = "coord")]
    public Coord Coord { get; set; }

    [XmlElement(ElementName = "country")]
    public string Country { get; set; }

    [XmlElement(ElementName = "timezone")]
    public int Timezone { get; set; }

    [XmlElement(ElementName = "sun")]
    public Sun Sun { get; set; }

    [XmlAttribute(AttributeName = "id")]
    public int Id { get; set; }

    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }
}

