namespace ScreenSound.Modelos;

internal interface IAvaliavel // Assinaturas que uma classe deverá ter ao implementar essa interface
{
    double Media { get; }
    void AdicionarNota(Avaliacao nota);
}
