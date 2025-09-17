namespace GBS_M320;

internal class Program
{
    private static void Main(string[] args)
    {
        var instance = new Quadrat
        {
            SeitenLänge = 4.0
        };
        instance.Verschiebe(2.0, 3.0);
        instance.Skaliere(2.0);
        instance.Print();
    }
}