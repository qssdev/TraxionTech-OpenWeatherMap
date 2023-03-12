using System.Xml.Serialization;

[XmlRoot(ElementName = "direction")]
public class Direction
{

    [XmlAttribute(AttributeName = "value")]
    public int Value { get; set; }

    [XmlAttribute(AttributeName = "code")]
    public string Code { get; set; }

    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }
}

