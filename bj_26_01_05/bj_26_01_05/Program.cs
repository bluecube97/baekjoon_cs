internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int a = int.Parse(isr.ReadLine());
        int b = int.Parse(isr.ReadLine());

        Console.WriteLine(b + b - a);
    }
}