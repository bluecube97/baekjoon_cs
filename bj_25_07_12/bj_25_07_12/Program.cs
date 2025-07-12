internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (true)
        {
            int n = int.Parse(isr.ReadLine());

            // 1^2 / 2^2 + 1^2 / 3^2 + 2^2 + 1^2
            if (n == 0)
                break;

            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }

            Console.WriteLine(sum);
        }
    }
}