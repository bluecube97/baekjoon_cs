internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] ab = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = ab[0];
        int b = ab[1];

        a /= 2;

        if (a + b < n)
        {
            Console.WriteLine(a + b);
        }
        else
        {
            Console.WriteLine(n);
        }
    }
}