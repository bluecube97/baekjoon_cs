internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(isr.ReadLine());
            if (n <= 25)
            {
                Console.WriteLine("Case #{0}: World Finals", i + 1);
            }
            else if (n <= 1000)
            {
                Console.WriteLine("Case #{0}: Round {1}", i + 1, 3);
            }
            else if (n <= 4500)
            {
                Console.WriteLine("Case #{0}: Round {1}", i + 1, 2);
            }
            else
            {
                Console.WriteLine("Case #{0}: Round {1}", i + 1, 1);
            }
        }
    }
}