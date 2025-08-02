internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] abc = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = abc[0], b = abc[1], c = abc[2];

        if (a == 0)
        {
            a = c * c - b;
            Console.WriteLine(a);
        }
        else if (b == 0)
        {
            b = c * c - a;
            Console.WriteLine(b);
        }
        else if (c == 0)
        {
            c = (int)Math.Sqrt(a + b);
            Console.WriteLine(c);
        }
    }
}