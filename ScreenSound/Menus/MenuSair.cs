using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas) // Método usado para avaliar bandas
    {
        Console.WriteLine("Tchau tchau :)");
    }
}
