internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] dart = isr.ReadLine().Split().Select(int.Parse).ToArray();
        double alice = 0;

        for (int i = 0; i < 20; i++)
        {
            if (dart[i] == 20)
            {
                if (i == 0)
                {
                    alice = dart[19] + dart[0] + dart[1];
                }
                else if (i == 19)
                {
                    alice = dart[18] + dart[19] + dart[0];
                }
                else
                {
                    alice = dart[i - 1] + dart[i] + dart[i + 1];
                }

                break;
            }
        }

        alice /= 3;

        if (alice > 10.5)
        {
            Console.WriteLine("Alice");
        }
        else if (alice < 10.5)
        {
            Console.WriteLine("Bob");
        }
        else
        {
            Console.WriteLine("Tie");
        }
    }
}