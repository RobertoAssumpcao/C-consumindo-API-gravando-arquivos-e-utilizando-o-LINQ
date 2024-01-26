try
{
    using HttpClient client = new();
    var resposa = await client.GetAsync("https://www.cheapshark.com/api/1.0/deals");

    if (resposa.IsSuccessStatusCode)
        Console.WriteLine(resposa);
    else
        Console.WriteLine("Erro");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}