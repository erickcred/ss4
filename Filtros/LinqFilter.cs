using ScreenSoundApi.Modelos;

namespace ScreenSoundApi.Filtros;

internal class LinqFilter
{
  public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
  {
    List<string> generos = musicas.Select(g => g.Genero).Distinct().ToList();

    Console.WriteLine("Generos: ");
    foreach (string genero in generos)
      Console.WriteLine($"- {genero}");
  }

  public static void FiltrarArtitasPorGeneroMusical(List<Musica> musicas, string genero)
  {
    var artistaPorGeneroMusical = musicas.Where(a => a.Genero.Contains(genero)).Select(a => a.Artista).Distinct().ToList();

    Console.WriteLine($"Artistas por Genero {genero}: ");
    foreach (var artista in artistaPorGeneroMusical)
      Console.WriteLine($"- {artista}");
  }

  public static void FiltrarMusicaisDeUmArtista(List<Musica> musicas, string artista)
  {
    var musicasDoArtista = musicas.Where(a => a.Artista.Equals(artista)).ToList();

    Console.WriteLine($"Musicas do Artista: {artista}: ");
    foreach (var musica in musicasDoArtista)
      Console.WriteLine($"- {musica.Nome}");
  }



}
