internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string a = isr.ReadLine();
        string p = isr.ReadLine();

        Console.WriteLine(p);
    }
}