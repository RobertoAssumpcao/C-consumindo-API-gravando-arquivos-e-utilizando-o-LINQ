using DesafioDesserializar.Models;
using Newtonsoft.Json;

try
{
    using HttpClient client = new();
    #region Filmes
    /*var resposa = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
    var filme = JsonSerializer.Deserialize<List<Filme>>(resposa)!;*/
    #endregion

    #region Paises
    /*var resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
    var paises = JsonConvert.DeserializeObject<List<Pais>>(resposta);*/
    #endregion

    #region Carros
    /*var resposa = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
    var carros = JsonConvert.DeserializeObject<List<Carro>>(resposa);*/
    #endregion

    #region Livro
    var resposa = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
    var livros = JsonConvert.DeserializeObject<List<Livro>>(resposa);
    #endregion
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}