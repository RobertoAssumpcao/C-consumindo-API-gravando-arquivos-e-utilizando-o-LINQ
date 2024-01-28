using Newtonsoft.Json;

namespace DesafioTonalidade.Models;

public class Musica
{
    [JsonProperty("song")] public string? Nome { get; set; }

    [JsonProperty("key")] public int Tonalidade { get; set; }

    public static List<string?> FiltrarSomenteDo(IEnumerable<Musica>? musicas)
    {
        return !musicas.Any() ? [] : musicas.Where(m => m.Tonalidade == 1).Select(m => m.Nome).ToList();
    }
}