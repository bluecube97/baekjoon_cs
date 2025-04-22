internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int d1 = int.Parse(isr.ReadLine());
        int d2 = int.Parse(isr.ReadLine());

        double len = d1 * 2 + 2 * d2 * 3.141592;

        Console.WriteLine("{0:F6}", len);
    }
}