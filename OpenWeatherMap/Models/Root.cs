
using Newtonsoft.Json;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

[DataContract(Name ="root")]
public class JsonData
{
    [JsonProperty("coord")]
    [JsonPropertyName("coord")]
    public Coord coord { get; set; }

    [JsonProperty("weather")]
    [JsonPropertyName("weather")]
    public List<Weather> weather { get; set; }

    [JsonProperty("base")]
    [JsonPropertyName("base")]
    public string @base { get; set; }

    [JsonProperty("main")]
    [JsonPropertyName("main")]
    public Main main { get; set; }

    [JsonProperty("visibility")]
    [JsonPropertyName("visibility")]
    public int visibility { get; set; }

    [JsonProperty("wind")]
    [JsonPropertyName("wind")]
    public WindJson wind { get; set; }

    [JsonProperty("clouds")]
    [JsonPropertyName("clouds")]
    public Clouds clouds { get; set; }

    [JsonProperty("dt")]
    [JsonPropertyName("dt")]
    public int dt { get; set; }

    [JsonProperty("sys")]
    [JsonPropertyName("sys")]
    public Sys sys { get; set; }

    [JsonProperty("timezone")]
    [JsonPropertyName("timezone")]
    public int timezone { get; set; }

    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonProperty("name")]
    [JsonPropertyName("name")]
    public string name { get; set; }

    [JsonProperty("cod")]
    [JsonPropertyName("cod")]
    public int cod { get; set; }
}
