namespace ScreenSound.Modelos;

internal class Avaliacao
{
    public Avaliacao(int nota)
    {
        Nota = nota;
    }

    public int Nota { get; }

    public static Avaliacao Parse(string texto) // Método estático que converte a entrada e retorna uma saída numérica do tipo 'int' a classe Program
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}
