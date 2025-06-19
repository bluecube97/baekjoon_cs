internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] hour = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int h = hour[0];
        int m = hour[1];
        int s = hour[2];

        int sec = h * 3600 + m * 60 + s;

        int q = int.Parse(isr.ReadLine());

        for (int i = 0; i < q; i++)
        {
            int[] query = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int t = query[0];

            switch (t)
            {
                case 1:
                    int c = query[1];
                    sec = (sec + c) % 86400;
                    break;
                case 2:
                    c = query[1];
                    sec = (sec - c) % 86400;
                    if (sec < 0) sec += 86400;
                    break;
                case 3:
                    Console.WriteLine(sec / 3600 + " " + (sec % 3600) / 60 + " " + sec % 60);
                    break;
            }
        }
    }
}