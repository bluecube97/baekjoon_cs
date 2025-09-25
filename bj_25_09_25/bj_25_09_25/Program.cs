internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nul = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nul[0];
        int u = nul[1];
        int l = nul[2];

        if (n >= 1000 && (u >= 8000 || l >= 260))
        {
            Console.WriteLine("Very Good");
        }
        else if (n >= 1000)
        {
            Console.WriteLine("Good");
        }
        else
        {
            Console.WriteLine("Bad");
        }
    }
}