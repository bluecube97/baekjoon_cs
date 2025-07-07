internal class Program
{
    static void Main()
    {
        //var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int max = m;

        for (int i = 0; i < n; i++)
        {
            int[] car = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int input = car[0];
            int output = car[1];

            int change = input - output;

            if (m + change < 0)
            {
                Console.WriteLine(0);
                return;
            }

            m += change;
            max = Math.Max(max, m);
        }

        Console.WriteLine(max);
    }
}