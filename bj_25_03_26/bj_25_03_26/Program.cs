internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int h = int.Parse(isr.ReadLine());
        int w = int.Parse(isr.ReadLine());
        float r = (float)Math.Min(h, w) / 2;

        Console.WriteLine(r * 100);
    }
}