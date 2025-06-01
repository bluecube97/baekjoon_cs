internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nwh = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nwh[0], w = nwh[1], h = nwh[2];

        for (int i = 0; i < n; i++)
        {
            int len = int.Parse(isr.ReadLine());

            if (Math.Pow(len, 2) <= Math.Pow(w, 2) + Math.Pow(h, 2))
            {
                Console.WriteLine("DA");
            }
            else
            {
                Console.WriteLine("NE");
            }
        }
    }
}