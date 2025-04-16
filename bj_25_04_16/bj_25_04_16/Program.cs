internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        int a = n * 78 / 100;
        int b = n - (n * 20 / 100 * 22 / 100);

        Console.WriteLine($"{a} {b}");
    }
}