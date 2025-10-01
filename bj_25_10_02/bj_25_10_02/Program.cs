internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string str = isr.ReadLine();
        int i = 0;

        foreach (var c in str)
        {
            if (i % 10 == 0 && i != 0)
            {
                Console.WriteLine();
            }
            Console.Write(c);
            i++;
        }
    }
}