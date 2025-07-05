internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        int count = 0;

        while (isr.Peek() != -1)
        {
            isr.ReadLine();
            count++;
        }

        Console.WriteLine(count);
    }
}