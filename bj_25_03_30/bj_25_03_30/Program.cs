internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        if (n % 8 == 1)
        {
            Console.WriteLine("1");
        }
        else if (n % 8 == 2 || n % 8 == 0)
        {
            Console.WriteLine("2");
        }
        else if (n % 8 == 3 || n % 8 == 7)
        {
            Console.WriteLine("3");
        }
        else if (n % 8 == 4 || n % 8 == 6)
        {
            Console.WriteLine("4");
        }
        else if (n % 8 == 5)
        {
            Console.WriteLine("5");
        }
    }
}