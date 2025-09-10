internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] ts = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int t = ts[0];
        int s = ts[1];

        if (t >= 12 && t <= 16 && s == 0)
        {
            Console.WriteLine(320);
        }
        else
        {
            Console.WriteLine(280);
        }
    }
}