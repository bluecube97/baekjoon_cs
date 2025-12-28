internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = n - i - 1; j > 0; j--)
            {
                Console.Write(" ");
            }
            Console.Write("*");
            for (int j = 0; j < i * 2 - 1; j++)
            {
                Console.Write(" ");
            }
            if (i != 0)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        for (int i = 0; i < n * 2 - 1; i++)
        {
            Console.Write("*");
        }
    }
}