using Newtonsoft.Json;

namespace DesafioDesserializar.Models;

public class Livro
{
    public string Titulo { get; set; }

    public string Autor { get; set; }

    [JsonProperty("ano_publicacao")]
    public int AnoPublicacao { get; set; }

    public string Genero { get; set; }

    public int Paginas { get; set; }
    public string Editora { get; set; }
}
