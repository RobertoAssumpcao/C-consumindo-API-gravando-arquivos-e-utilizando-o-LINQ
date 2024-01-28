using DesafioTonalidade.Models;
using Newtonsoft.Json;

try
{
    using HttpClient client = new();
    var resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonConvert.DeserializeObject<List<Musica>>(resposta);
    foreach (var musica in musicas)
    {
        switch (musica.Tonalidade)
        {
            case 0:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: C");
                break;
            case 1:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: C#");
                break;
            case 2:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: D");
                break;
            case 3:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: D#");
                break;
            case 4:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: E");
                break;
            case 5:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: F");
                break;
            case 6:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: F#");
                break;
            case 7:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: G");
                break;
            case 8:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: G#");
                break;
            case 9:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: A");
                break;
            case 10:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: A#");
                break;
            case 11:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: B");
                break;
            default:
                Console.WriteLine("Nome: " + musica.Nome + " Tonalidade: " + musica.Tonalidade);
                break;
        }
    }

    foreach (var musica in Musica.FiltrarSomenteDo(musicas))
    { 
        Console.WriteLine(musica);
    }
    
    Console.WriteLine(Musica.FiltrarSomenteDo(musicas).Count);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}