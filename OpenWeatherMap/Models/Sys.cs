using Newtonsoft.Json;
using System.Text.Json.Serialization;

public class Sys
{
    [JsonProperty("type")]
    [JsonPropertyName("type")]
    public int type { get; set; }

    [JsonProperty("id")]
    [JsonPropertyName("id")]
    public int id { get; set; }

    [JsonProperty("country")]
    [JsonPropertyName("country")]
    public string country { get; set; }

    [JsonProperty("sunrise")]
    [JsonPropertyName("sunrise")]
    public int sunrise { get; set; }

    [JsonProperty("sunset")]
    [JsonPropertyName("sunset")]
    public int sunset { get; set; }
}
