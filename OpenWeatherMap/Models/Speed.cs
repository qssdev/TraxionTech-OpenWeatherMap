using System.Xml.Serialization;

[XmlRoot(ElementName = "speed")]
public class Speed : BaseValueUnit
{
    [XmlAttribute(AttributeName = "name")]
    public string Name { get; set; }
}

