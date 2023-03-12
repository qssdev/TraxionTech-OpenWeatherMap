using System.Xml.Serialization;

[XmlRoot(ElementName = "clouds")]
public class CloudsNameValue
{

    [XmlAttribute(AttributeName = "value")]
    public int Value { get; set; }

    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }
}

