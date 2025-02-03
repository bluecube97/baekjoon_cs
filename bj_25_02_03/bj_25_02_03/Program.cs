internal class Program
{
    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCase; i++)
        {
            int jBox = int.Parse(Console.ReadLine());

            if (jBox == 1)
            {
                Console.WriteLine('#');
                Console.WriteLine();
                continue;
            }

            for (int j = 0; j < jBox; j++)
            {
                Console.Write('#');
            }

            Console.WriteLine();

            for (int j = 0; j < jBox - 2; j++)
            {
                for (int k = 0; k < jBox; k++)
                {
                    if (k == 0 || k == jBox - 1)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('J');
                    }
                }

                Console.WriteLine();
            }

            for (int j = 0; j < jBox; j++)
            {
                Console.Write('#');
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}