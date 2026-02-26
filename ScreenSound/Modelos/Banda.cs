namespace ScreenSound.Modelos;

internal class Banda : IAvaliavel
{
    private List<Album> albuns = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    public Banda(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; } // AutoPropertie
    public double Media // Propiedade GET com método para fornecer a média de notas de uma banda 
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    public List<Album> Albuns => albuns;

    public void AdicionarAlbum(Album album) // Método para adicionar um álbum à uma banda
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(Avaliacao nota) // Método para adicionar a nota à uma banda
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia() // Método para ler e exibir as informações (discografia) ao usuário
    {
        Console.WriteLine($"Discografia da Banda | {Nome}");
        foreach (Album album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} / Duração: ({album.DuracaoTotal} min)");
        }
    }
}