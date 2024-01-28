using GameOfThronesAPI.Models;
using Newtonsoft.Json;

using HttpClient client = new();

try
{
    var resposta = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");
    var pessoa = JsonConvert.DeserializeObject<Pessoa>(resposta); 
    
    Console.WriteLine("Url: {0}", pessoa.Url);
    Console.WriteLine("Nome: {0}", pessoa.Nome);
    Console.WriteLine("Genero: {0}", pessoa.Genero);
    Console.WriteLine("Cultura: {0}", pessoa.Cultura);
    Console.WriteLine("Local de Nascimento: {0}", pessoa.LocalNascimento);
    Console.WriteLine("Morte: {0}", pessoa.Morte);
    Console.WriteLine("Titulos: {0}", string.Join(", ", pessoa.Titulos));
    Console.WriteLine("Relacionado: {0}", string.Join(", ", pessoa.Relacionado));
    Console.WriteLine("Pai: {0}", pessoa.Pai);
    Console.WriteLine("Mae: {0}", pessoa.Mae);
    Console.WriteLine("Conjuge: {0}", pessoa.Conjuge);
    Console.WriteLine("Lealdades: {0}", string.Join(", ", pessoa.lealdades));
    Console.WriteLine("Livros: {0}", string.Join(", ", pessoa.Livros));
    Console.WriteLine("PosLivros: {0}", string.Join(", ", pessoa.PosLivros));
    Console.WriteLine("TvTemporada: {0}", string.Join(", ", pessoa.TvTemporada));
    Console.WriteLine("FeitaPor: {0}", string.Join(", ", pessoa.FeitaPor));
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}