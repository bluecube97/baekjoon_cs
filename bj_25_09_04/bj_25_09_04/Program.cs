internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int r = input[0];
        int c = input[1];
        int n = input[2];
        
        long divR = r / n;
        long divC = c / n;

        if (r % n != 0)
            divR++;
        if (c % n != 0)
            divC++;

        Console.WriteLine(divR * divC);
    }
}