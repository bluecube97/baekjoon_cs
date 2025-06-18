internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int b = int.Parse(isr.ReadLine());
        Console.WriteLine((int)(b * 10 / 11));
    }
}