using System.Xml.Serialization;

[XmlRoot(ElementName = "humidity")]
public class Humidity : BaseValueUnit
{

}

public interface IValueUnit
{
    int Value { get; set; }
    string Unit { get; set; }
}

public class BaseValueUnit : IValueUnit
{

    [XmlAttribute(AttributeName = "value")]
    public int Value { get; set; }

    [XmlAttribute(AttributeName = "unit")]
    public string Unit { get; set; }
}