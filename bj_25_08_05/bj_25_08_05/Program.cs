internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        double[] abc = isr.ReadLine().Split().Select(double.Parse).ToArray();
        double a = abc[0], b = abc[1], c = abc[2];
        double[] ijk = isr.ReadLine().Split().Select(double.Parse).ToArray();
        double i = ijk[0], j = ijk[1], k = ijk[2];

        double x = Math.Min(a / i, Math.Min(b / j, c / k));

        double remainA = a - i * x;
        double remainB = b - j * x;
        double remainC = c - k * x;

        Console.WriteLine($"{remainA:F6} {remainB:F6} {remainC:F6}");
    }
}