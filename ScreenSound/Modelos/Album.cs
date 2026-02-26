namespace ScreenSound.Modelos;

internal class Album : IAvaliavel
{
    private List<Musica> musicas = new List<Musica>(); // Lista para armazenar as músicas do álbum
    private List<Avaliacao> notas = new();

    public Album(string nome) // Construtor requisita que insira o nome do álbum na instanciação
    {
        Nome = nome;
    }

    public string Nome { get; } // AutoPropertie
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); // Expressão lambda para guardar o método de soma da duração das músicas do álbum
    public List<Musica> Musicas => musicas;

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

    public void AdicionarMusica(Musica musica) // Método para adicionar uma música ao álbum
    {
        musicas.Add(musica);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirMusicasDoAlbum() // Método para ler e exibir todas as músicas do álbum ao usuário
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}:\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"\nPara ouvir este álbum inteiro, você precisa de {DuracaoTotal} segundos.");
    }
}