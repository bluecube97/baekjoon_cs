internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        Console.WriteLine(n -2024);
    }
}