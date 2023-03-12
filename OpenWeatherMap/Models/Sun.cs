using System.Xml.Serialization;

[XmlRoot(ElementName = "sun")]
public class Sun
{

    [XmlAttribute(AttributeName = "rise")]
    public DateTime Rise { get; set; }

    [XmlAttribute(AttributeName = "set")]
    public DateTime Set { get; set; }
}

