using UsandoApiDeMusicas.Modelos;

namespace UsandoApiDeMusicas.Filtros;

internal class LinqFiltros
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList(); // seleciona as músicas, pega apenas os gêneros e retira repetições
        foreach (var genero in todosOsGenerosMusicais) 
        {
            Console.WriteLine($"- {genero}");
            Console.WriteLine(); // pula uma linha
        }
    }

    public static void FiltrarArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {

        // pega o gênero da música, verifica se tem o gênero e depois seleciona apenas o artista
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine("Exibindo os artistas por gênero musical: ");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
            Console.WriteLine();
        }

    }

    public static void FiltrarMusicaDoArtista(List<Musica> musicas, string nomeDoArtista) 
    {
        var musicaDoArtista = musicas.Where(musica => musica.Artista.Equals(nomeDoArtista)).ToList();
        Console.WriteLine("Músicas do artista:");

        foreach (var musica in musicaDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
            Console.WriteLine();
        }
    }

}
