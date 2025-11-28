internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            double[] nc = isr.ReadLine().Split().Select(double.Parse).ToArray();
            double n = nc[0];
            double c = nc[1];

            Console.WriteLine(Math.Ceiling(n / c));
        }
    }
}