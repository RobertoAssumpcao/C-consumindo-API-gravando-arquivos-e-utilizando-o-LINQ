using HttpClient client = new();
string? resposa = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
Console.WriteLine(resposa);