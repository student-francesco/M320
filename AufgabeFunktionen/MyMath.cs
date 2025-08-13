using System.Runtime.CompilerServices;

namespace AufgabeFunktionen;

public class MyMath
{
    public int CalcGgt(int a, int b)
    {
        int z;
        while (b != 0)
        {
            z = a % b;
            a = b;
            b = z;
        }
        return a;
    }
    
    public int CalcKgv(int a, int b)
    {
        return a * b / CalcGgt(a, b);
    }

    public int ReadInt()
    {
        var input = Console.ReadLine();
        var asInt = uint.Parse(input!);
        if (asInt == 0) throw new InvalidOperationException($"{nameof(CalcGgt)} does not support zero.");
        return (int)asInt;
    }
}