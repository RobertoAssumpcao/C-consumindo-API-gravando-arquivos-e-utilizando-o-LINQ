try
{
    using HttpClient client = new();
    string? resposa = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
    Console.WriteLine(resposa);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}