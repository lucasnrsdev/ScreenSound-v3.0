using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarBanda : Menu // Utilização de Herança da classe Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) // Método usado para avaliar bandas, permitindo a extensão da implementação virtual do método herdado
    {
        base.Executar(bandasRegistradas); // Acessa e executa o método herdado
        TituloDaOpcao("Avaliar banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda)) // Verifica se a banda está registrada na lista (ou dicionário)
        {
            Banda banda = bandasRegistradas[nomeDaBanda]; // Obtem o nome da banda na lista de bandas registradas
            Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
            Avaliacao notaDaBanda = Avaliacao.Parse(Console.ReadLine()!);
            banda.AdicionarNota(notaDaBanda); // Adiciona a nota da banda à lista de avaliações da banda
            Console.WriteLine($"\nA nota {notaDaBanda.Nota} foi registrada com sucesso para a banda {nomeDaBanda}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        ExibirLogo();
    }
}
