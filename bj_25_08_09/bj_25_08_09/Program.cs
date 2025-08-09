internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        for (int i = 0; i < 3; i++)
        {
            int[] t = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int sh = t[0], sm = t[1], ss = t[2];
            int eh = t[3], em = t[4], es = t[5];

            int start = sh * 3600 + sm * 60 + ss;
            int end = eh * 3600 + em * 60 + es;

            int diff = end - start;

            int h = diff / 3600;
            diff %= 3600;
            int m = diff / 60;
            int s = diff % 60;

            Console.WriteLine($"{h} {m} {s}");
        }
    }
}