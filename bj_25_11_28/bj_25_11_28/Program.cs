internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int count = 0;

        for (int x = 1; x * x <= n; x++)
        {
            if (n % x != 0) continue;

            int y = n / x;

            if ((x + y) % 2 != 0) continue;

            int a = (x + y) / 2;
            int b = (y - x) / 2;

            if (b >= 1 && a >= b && a <= 500) count++;
        }

        Console.WriteLine(count);
    }
}