internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string str = isr.ReadLine();
        Console.WriteLine(str.Length);
    }
}