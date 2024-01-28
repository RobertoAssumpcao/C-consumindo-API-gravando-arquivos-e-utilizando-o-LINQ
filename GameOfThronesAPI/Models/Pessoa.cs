using Newtonsoft.Json;

namespace GameOfThronesAPI.Models;

public class Pessoa
{
    public string? Url { get; set; }

    [JsonProperty("name")] public string? Nome { get; set; }

    [JsonProperty("gender")] public string? Genero { get; set; }

    [JsonProperty("culture")] public string? Cultura { get; set; }

    [JsonProperty("born")] public string? LocalNascimento { get; set; }

    [JsonProperty("died")] public string? Morte { get; set; }

    [JsonProperty("titles")] public List<string> Titulos { get; set; }

    [JsonProperty("aliases")] public List<string> Relacionado { get; set; }

    [JsonProperty("father")] public string? Pai { get; set; }

    [JsonProperty("mother")] public string? Mae { get; set; }

    [JsonProperty("spouse")] public string? Conjuge { get; set; }

    [JsonProperty("allegiances")] public List<string> lealdades { get; set; }

    [JsonProperty("books")] public List<string> Livros { get; set; }

    [JsonProperty("povBooks")] public List<string> PosLivros { get; set; }

    [JsonProperty("tvSeries")] public List<string> TvTemporada { get; set; }

    [JsonProperty("playedBy")] public List<string> FeitaPor { get; set; }
}