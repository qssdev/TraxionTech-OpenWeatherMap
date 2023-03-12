using System.Xml.Serialization;

[XmlRoot(ElementName = "visibility")]
public class Visibility
{

    [XmlAttribute(AttributeName = "value")]
    public int Value { get; set; }
}

