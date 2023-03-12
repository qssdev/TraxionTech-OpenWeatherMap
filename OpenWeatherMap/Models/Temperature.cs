using System.Xml.Serialization;

[XmlRoot(ElementName = "temperature")]
public class Temperature : BaseValueUnit
{
    [XmlAttribute(AttributeName = "min")]
    public double Min { get; set; }

    [XmlAttribute(AttributeName = "max")]
    public double Max { get; set; }

}

