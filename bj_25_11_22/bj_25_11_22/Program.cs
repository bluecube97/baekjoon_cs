internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int w = int.Parse(isr.ReadLine());

        for (int i = 2; i < 500; i++)
        {
            if (i * i / 2 == w)
            {
                Console.WriteLine(i * 4);
            }
        }
    }
}