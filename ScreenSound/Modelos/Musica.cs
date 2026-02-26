namespace ScreenSound.Modelos;

internal class Musica
{
    public Musica(Banda artista, string nome) // Construtor requisita que insira o nome da banda e o nome da música da banda na instanciação
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; } // AutoProperties
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence à banda {Artista}"; // Expressão lambda para armazenar para depois exibir uma breve descrição da música

    public void ExibirFichaTecnica() // Método que exibe a ficha da música, com uma verificação de disponibilidade da música ao usuário
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
}