internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        int n = int.Parse(isr.ReadLine());
        int[] a = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int[] b = isr.ReadLine().Split().Select(int.Parse).ToArray();

        int bicycle = a.Length;
        int sum = 0;

        for (int i = 0; i < bicycle; i++)
        {
            sum += Math.Abs(a[i] - b[i]);
        }

        Console.WriteLine(sum / 2);
    }
}