using HttpClient client = new();
var resposa = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
Console.WriteLine(resposa);