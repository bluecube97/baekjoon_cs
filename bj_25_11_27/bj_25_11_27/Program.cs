internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] xy = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int x = xy[0];
        int y = xy[1];

        string a = "", b = "";

        for (int i = 0; i < x; i++)
        {
            a += "1";
        }
        for (int i = 0; i < y; i++)
        {
            b += "1";
        }

        Console.WriteLine(int.Parse(a) + int.Parse(b));
    }
}