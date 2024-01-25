﻿using System.Text.Json.Serialization;

namespace DesafioDesserializar.Models;

public class Filme
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("rank")]
    public string? Rank { get; set; }

    [JsonPropertyName("title")]
    public string? Titulo { get; set; }

    [JsonPropertyName("fullTitle")]
    public string? TituloCompleto { get; set; }

    [JsonPropertyName("year")]
    public string? Ano { get; set; }

    [JsonPropertyName("image")]
    public string? LinkImagem { get; set; }

    [JsonPropertyName("crew")]
    public string? Equipe { get; set; }

    [JsonPropertyName("imDbRating")]
    public string? Nota { get; set; }

    [JsonPropertyName("imDbRatingCount")]
    public string? QuantidadeAvaliacao { get; set; }
}
