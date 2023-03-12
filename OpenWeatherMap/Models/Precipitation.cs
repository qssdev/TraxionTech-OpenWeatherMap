using System.Xml.Serialization;

[XmlRoot(ElementName = "precipitation")]
public class Precipitation
{

    [XmlAttribute(AttributeName = "mode")]
    public string Mode { get; set; }
}

