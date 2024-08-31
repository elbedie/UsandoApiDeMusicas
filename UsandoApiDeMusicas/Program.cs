using System.Text.Json;
using UsandoApiDeMusicas.Filtros;
using UsandoApiDeMusicas.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        // Retorna todos os dados da API:
        string retornoDadosDasMusicas = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
       

        // transforma os dados da API em um objeto para manipulá-los
        var musicas = JsonSerializer.Deserialize<List<Musica>>(retornoDadosDasMusicas);

        /* LinqOrder.ExibirArtistasOrdenados(musicas);*/

        /* LinqFiltros.FiltrarArtistaPorGeneroMusical(musicas, "pop");*/

        /*LinqFiltros.FiltrarMusicaDoArtista(musicas, "Lady Gaga");*/

        /*LinqFiltros.FiltrarTodosOsGenerosMusicais(musicas);*/
        /*foreach (Musica musica in musicas)
        {
            musica.ExibirDetalhesDaMusica();
            Console.WriteLine();
        }*/

        var listaDeMusicasFavoritasDoDiego = new MusicasFavoritas("Diego");  // criando um objeto do tipo MusicasFavoritas
        listaDeMusicasFavoritasDoDiego.AdicionarMusicasFavoritas(musicas[90]);
        listaDeMusicasFavoritasDoDiego.AdicionarMusicasFavoritas(musicas[190]);
        listaDeMusicasFavoritasDoDiego.AdicionarMusicasFavoritas(musicas[950]);
        listaDeMusicasFavoritasDoDiego.AdicionarMusicasFavoritas(musicas[890]);
        listaDeMusicasFavoritasDoDiego.AdicionarMusicasFavoritas(musicas[198]);

        listaDeMusicasFavoritasDoDiego.ExibirMusicasFavoritas();
        listaDeMusicasFavoritasDoDiego.GerarArquivoJson();

    }
    catch(Exception ex)
    {
        Console.WriteLine($"Não foi possível retornar os dados da API. Erro: {ex.Message}"); 
    }
    
}