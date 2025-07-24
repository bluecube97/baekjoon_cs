internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int[] rec = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int r = rec[0];
            int e = rec[1];
            int c = rec[2];

            if (r > e - c)
            {
                Console.WriteLine("do not advertise");
            }
            else if (r < e - c)
            {
                Console.WriteLine("advertise");
            }
            else
            {
                Console.WriteLine("does not matter");
            }
        }
    }
}