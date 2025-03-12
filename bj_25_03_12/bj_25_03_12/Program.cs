internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        if (n == 0)
        {
            Console.WriteLine("divide by zero");
            return;
        }
        int[] practice = isr.ReadLine().Split().Select(int.Parse).ToArray();

        float ave = (float) practice.Sum() / n;
        float exp = (float) practice.Sum() * (1.0f / n);

        if (exp == 0)
        {
            Console.WriteLine("divide by zero");
            return;
        }

        Console.WriteLine("{0:F2}", ave / exp);
    }
}