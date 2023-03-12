using System.Xml.Serialization;

[XmlRoot(ElementName = "lastupdate")]
public class Lastupdate
{

    [XmlAttribute(AttributeName = "value")]
    public DateTime Value { get; set; }
}

