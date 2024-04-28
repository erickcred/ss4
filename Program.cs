using ScreenSoundApi.Filtros;
using ScreenSoundApi.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
  try
  {
    string urlBase = "https://guilhermeonrails.github.io/api-csharp-songs/songs.json";
    string resposta = await client.GetStringAsync(urlBase);
    List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

    //Console.WriteLine("1 - Listar Artistas de A-z");
    //Console.WriteLine("2 - Listar Artistas por Genero");
    //Console.WriteLine("3 - Listar Todos os Generos");
    //Console.WriteLine("4 - Listar Todas as Musicas de um Artista");
    //int opcaoNumerica = int.Parse(Console.ReadLine()!);
    
    //switch (opcaoNumerica)
    //{
    //  case 1:
    //    LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
    //    break;
    //  case 2:
    //    LinqFilter.FiltrarArtitasPorGeneroMusical(musicas, "rock");
    //    break;
    //  case 3:
    //    LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    //    break;
    //  case 4:
    //    LinqFilter.FiltrarMusicaisDeUmArtista(musicas, "U2");
    //    break;
    //  default:
    //    Console.WriteLine("Deu errado!!!");
    //    break;
    //}

    
    var musicasPreferidas = new MusicasPreferidas("Erick");
    musicasPreferidas.AdicionarMusicasFavoritas(musicas[1]);
    musicasPreferidas.AdicionarMusicasFavoritas(musicas[2]);
    musicasPreferidas.AdicionarMusicasFavoritas(musicas[3]);
    musicasPreferidas.AdicionarMusicasFavoritas(musicas[4]);
    musicasPreferidas.AdicionarMusicasFavoritas(musicas[5]);

    musicasPreferidas.ExibirMusicasFavoritas();
    musicasPreferidas.GerarArquivoJson();
  }
  catch (HttpRequestException ex)
  {
    Console.WriteLine($"Não foi possicel acessar a API \r\nErrorMessage: {ex.Message}");
  }
  catch (Exception ex)
  {
    Console.WriteLine($"Não foi possicel acessar a API \r\nErrorMessage: {ex.Message}");
  }
}