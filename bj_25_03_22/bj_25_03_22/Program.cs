internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}. {1}", i + 1, isr.ReadLine());
        }
    }
}