internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nm[0];
            int m = nm[1];

            if (n * m < 48 || n < 12 || m < 4)
            {
                Console.WriteLine(-1);
                continue;
            }

            Console.WriteLine(m * 11 + 4);
        }
    }
}