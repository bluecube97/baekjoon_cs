internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int direction = 0;  // 0 == N, 1 == E, 2 == S, 3 == W

        for (int i = 0; i < 10; i++)
        {
            int t = int.Parse(isr.ReadLine());

            if (t == 1)
            {
                direction += 1;
                direction %= 4;
            }
            else if (t == 2)
            {
                direction += 2;
                direction %= 4;
            }
            else
            {
                direction += 3;
                direction %= 4;
            }
        }

        switch (direction)
        {
            case 0:
                Console.WriteLine("N");
                break;
            case 1:
                Console.WriteLine("E");
                break;
            case 2:
                Console.WriteLine("S");
                break;
            case 3:
                Console.WriteLine("W");
                break;
        }
    }
}