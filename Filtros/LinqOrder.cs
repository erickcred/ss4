using ScreenSoundApi.Modelos;

namespace ScreenSoundApi.Filtros
{
  internal class LinqOrder
  {
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
      List<string> artistas = musicas.OrderBy(m => m.Artista).Select(a => a.Artista).Distinct().ToList();

      Console.WriteLine("Artistas: A-z");
      foreach (string artista in artistas)
        Console.WriteLine($"- {artista}");
    }
  }
}
