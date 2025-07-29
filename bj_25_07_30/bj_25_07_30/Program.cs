internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("SciComLove");
        }
        else
        {
            Console.WriteLine("evoLmoCicS");
        }
    }
}