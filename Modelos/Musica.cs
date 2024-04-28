using System.Text.Json.Serialization;

namespace ScreenSoundApi.Modelos;

internal class Musica
{
  [JsonPropertyName("artist")]
  public string Artista { get; set; } = string.Empty;

  [JsonPropertyName("song")]
  public string Nome { get; set; } = string.Empty;

  [JsonPropertyName("duration_ms")]
  public int Duracap_ms { get; set; }

  [JsonPropertyName("explicit")]
  public string Explicit { get; set; } = string.Empty;

  [JsonPropertyName("year")]
  public string Ano { get; set; } = string.Empty;

  [JsonPropertyName("popularity")]
  public string Popularidade { get; set; } = string.Empty;

  [JsonPropertyName("danceability")]
  public string Dancabilidade { get; set; } = string.Empty;

  [JsonPropertyName("energy")]
  public string Energico { get; set; } = string.Empty;

  [JsonPropertyName("key")]
  public int Chave { get; set; }

  [JsonPropertyName("loudness")]
  public string Volume { get; set; } = string.Empty;

  [JsonPropertyName("mode")]
  public string Modo { get; set; } = string.Empty;

  [JsonPropertyName("speechiness")]
  public string Ddiscurso { get; set; } = string.Empty;

  [JsonPropertyName("acousticness")]
  public string Acustico { get; set; } = string.Empty;

  [JsonPropertyName("iinstrumentalness")]
  public string Instrumentabilidade { get; set; } = string.Empty;

  [JsonPropertyName("liveness")]
  public string Vivacidade { get; set; } = string.Empty;

  [JsonPropertyName("valence")]
  public string Valencia { get; set; } = string.Empty;

  [JsonPropertyName("tempo")]
  public string Tempo { get; set; } = string.Empty;

  [JsonPropertyName("genre")]
  public string Genero { get; set; } = string.Empty;

  public void ExibirDetalhesDaMusica()
  {
    Console.WriteLine($"Artista: {Artista}");
    Console.WriteLine($"Musica: {Nome}");
    Console.WriteLine($"Duração: {Duracap_ms / 1000}");
    Console.WriteLine($"Genero musical: {Genero}\r\n");
  }
}

