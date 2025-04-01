internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int num = int.Parse(isr.ReadLine());
            Console.Write("Pairs for {0}: ", num);

            for (int j = 1; j <= num / 2; j++)
            {
                int a = j;
                int b = num - j;

                if (a >= b)
                {
                    break;
                }

                if (j > 1)
                {
                    Console.Write(", ");
                }
                Console.Write("{0} {1}", a, b);
            }

            Console.WriteLine();
        }
    }
}