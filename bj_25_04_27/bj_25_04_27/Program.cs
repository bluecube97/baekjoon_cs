internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] drink = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = drink[0];
        int b = drink[1];
        int c = drink[2];

        int[] candidates = new int[]
        {
            a, b, c,
            a * b, a * c, b * c,
            a * b * c
        };

        int bestOdd = candidates.Where(x => x % 2 == 1).DefaultIfEmpty(0).Max();

        if (bestOdd > 0)
        {
            Console.WriteLine(bestOdd);
            return;
        }

        int bestEven = candidates.Max();
        Console.WriteLine(bestEven);
    }
}