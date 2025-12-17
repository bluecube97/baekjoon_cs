internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] abc = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int a = abc[0];
        int b = abc[1];
        int c = abc[2];

        Console.WriteLine(b * c * 3 / a);
    }
}