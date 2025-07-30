internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (isr.Peek() != -1)
        {
            int[] abc = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int a = abc[0], b = abc[1], c = abc[2];

            int max = Math.Max(b - a, c - b);
            Console.WriteLine(max - 1);
        }
    }
}