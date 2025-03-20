internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];

            Console.WriteLine("{0} {1}", m * 2 - n, m - (m * 2 - n));
        }
    }
}