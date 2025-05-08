internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }

            Console.Write("*");

            if (i != 0)
            {
                Console.Write(" ");
            }

            for (int j = 0; j < i - 1; j++)
            {
                Console.Write("  ");
            }

            if (i != 0)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}