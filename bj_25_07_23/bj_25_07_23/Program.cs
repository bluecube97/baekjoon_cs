internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string name = isr.ReadLine();

        for (int i = 0; i < 3; i++)
        {
            Console.Write(":fan:");
        }
        Console.WriteLine();

        Console.Write(":fan::");
        Console.Write(name);
        Console.WriteLine("::fan:");

        for (int i = 0; i < 3; i++)
        {
            Console.Write(":fan:");
        }
    }
}