internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        int count = (n - 1) / 4 + 1;

        for (int i = 0; i < count; i++)
        {
            Console.Write("long ");
        }
        Console.WriteLine("int");
    }
}