internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int m = int.Parse(isr.ReadLine());
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            int[] car = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int input = car[0];
            int output = car[1];

            int change = input - output;

            if (m + change < 0)
            {
                Console.WriteLine(0);
                break;
            }

            m += change;
            max = Math.Max(max, m);
        }

        Console.WriteLine(max);
    }
}