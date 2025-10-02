internal class Program
{
    static void Main()
    {
        // var isr = new StreamReader(Console.OpenStandardInput());

        Console.WriteLine("n e");
        Console.WriteLine("- -----------");

        double e = 0;
        int f = 1;

        for (int n = 0; n <= 9; n++)
        {
            if (n > 0) f *= n;
            e += 1.0 / f;

            if (n < 3)
                Console.WriteLine($"{n} {e}");
            else
                Console.WriteLine($"{n} {e:F9}");
        }
    }
}