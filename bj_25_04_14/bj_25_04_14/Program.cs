internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] abcm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = abcm[0];
        int b = abcm[1];
        int c = abcm[2];
        int m = abcm[3];

        int tired = 0;
        int work = 0;

        for (int i = 0; i < 24; i++)
        {
            if (tired + a <= m)
            {
                tired += a;
                work += b;
            }
            else
            {
                tired -= c;
                if (tired < 0)
                {
                    tired = 0;
                }
            }
        }

        Console.WriteLine(work);
    }
}