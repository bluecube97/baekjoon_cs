internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        for (int i = 0; i < n; i++)
        {
            isr.ReadLine();
            Console.WriteLine(1);
        }
    }
}