internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        double[] abc = isr.ReadLine().Split().Select(double.Parse).ToArray();
        double a = abc[0];
        double b = abc[1];
        double c = abc[2];

        double maxValue = double.MinValue;

        maxValue = Math.Max(maxValue, a * b / c);
        maxValue = Math.Max(maxValue, a / b * c);

        Console.WriteLine((int)maxValue);
    }
}