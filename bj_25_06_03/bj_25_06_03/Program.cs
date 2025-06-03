internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int r = int.Parse(isr.ReadLine());

        Console.WriteLine("{0:F6}", Math.Pow(r, 2) * Math.PI);
        Console.WriteLine("{0:F6}", 2 * Math.Pow(r, 2));
    }
}