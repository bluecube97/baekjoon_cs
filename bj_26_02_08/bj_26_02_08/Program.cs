internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        if (n == 1)
        {
            Console.Write("*");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }

        Console.WriteLine();

        for (int i = 0; i < n - 2; i++)
        {
            Console.Write("*");

            for (int j = 0; j < n - 2; j++)
            {
                if (i == j || j == (n - 3 - i))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine("*");
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
        }

        Console.WriteLine();
    }
}