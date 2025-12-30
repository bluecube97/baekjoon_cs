internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        double[] d = isr.ReadLine().Split().Select(double.Parse).ToArray();
        double d1 = d[0];
        double d2 = d[1];
        double d3 = d[2];

        double a = (d1 + d2 - d3) / 2.0;
        double b = (d1 + d3 - d2) / 2.0;
        double c = (d2 + d3 - d1) / 2.0;

        if (a <= 0 || b <= 0 || c <= 0)
        {
            Console.WriteLine("-1");
            return;
        }

        Console.WriteLine("1");
        Console.WriteLine(
            $"{Math.Round(a, 1):F1} {Math.Round(b, 1):F1} {Math.Round(c, 1):F1}"
        );
    }
}