namespace AufgabeFunktionen;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        while (true)
        {
            Console.WriteLine("Enter a, b and 1 for GGT, 2 for KGV:");
            var a = Console.ReadLine()!;
            var b = Console.ReadLine()!;
            var c = Console.ReadLine();
            switch (c)
            {
                case "1":
                    Console.WriteLine(new MyMath().CalcGgt(int.Parse(a), int.Parse(b)));
                    break;
                case "2":
                    Console.WriteLine(new MyMath().CalcKgv(int.Parse(a), int.Parse(b)));
                    break;
                default:
                    throw new InvalidOperationException("Invalid input.");
            }

            // 8.: It does not make sense to re-invent the wheel here!
            // See GetMedian() to calculate the median. .Min() and .Max() can be used to answer the remaining questions.
            
            // 9.
            var swapA = int.Parse(a);
            var swapB = int.Parse(b);
            MyMath.SwapNumbers(ref swapA, ref swapB);
        }
    }
}