using System.Text.Json;
using DesafioDesserializar.Models;

try
{
    using HttpClient client = new();
    var resposa = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");

    List<Filme> filme = JsonSerializer.Deserialize<List<Filme>>(resposa)!;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}