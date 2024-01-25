using System.Text.Json.Serialization;

namespace cheapshark.Models;

public class Music
{
    [JsonPropertyName()]
    public string? Nome { get; set; }
    public string? Artista { get; set; } 
}