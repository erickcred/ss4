using System.Text.Json;

namespace ScreenSoundApi.Modelos;

internal class MusicasPreferidas
{
  public string Nome { get; set; }
  public List<Musica> ListaDeMusicasFavoritas { get; }

  public MusicasPreferidas(string nome)
  {
    Nome = nome;
    ListaDeMusicasFavoritas = new List<Musica>();
  }

  public void AdicionarMusicasFavoritas(Musica musica)
  {
    ListaDeMusicasFavoritas.Add(musica);
  }

  public void ExibirMusicasFavoritas()
  {
    Console.WriteLine($"Essas são as musicas favoritas do {Nome}");
    foreach (var musica in ListaDeMusicasFavoritas)
      Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
  }

  public void GerarArquivoJson()
  {
    string path = $"MusicasFavoritas_{Nome}.json";
    string json = JsonSerializer.Serialize(new
    {
      nome = Nome,
      musicas = ListaDeMusicasFavoritas
    });

    //File.WriteAllText(path, json);
    using StreamWriter arquivo = new StreamWriter(path);
    arquivo.Write(json);
    arquivo.Close();
    Console.WriteLine("O arquivo Json foi criado com sucesso!");
  }


}
