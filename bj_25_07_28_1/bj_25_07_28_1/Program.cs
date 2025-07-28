internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int x = int.Parse(isr.ReadLine()!);
        int y = int.Parse(isr.ReadLine()!);

        if (x > 0 && y > 0)
        {
            Console.WriteLine(1);
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine(2);
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine(3);
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine(4);
        }
    }
}