using Newtonsoft.Json;
using System.Text.Json.Serialization;

public class Main
{
    [JsonProperty("temp")]
    [JsonPropertyName("temp")]
    public double temp { get; set; }

    [JsonProperty("feels_like")]
    [JsonPropertyName("feels_like")]
    public double feels_like { get; set; }

    [JsonProperty("temp_min")]
    [JsonPropertyName("temp_min")]
    public double temp_min { get; set; }

    [JsonProperty("temp_max")]
    [JsonPropertyName("temp_max")]
    public double temp_max { get; set; }

    [JsonProperty("pressure")]
    [JsonPropertyName("pressure")]
    public int pressure { get; set; }

    [JsonProperty("humidity")]
    [JsonPropertyName("humidity")]
    public int humidity { get; set; }
}
