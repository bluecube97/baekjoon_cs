internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int d = input[0];
        int h = input[1];
        int w = input[2];

        double d2 = Math.Sqrt(h * h + w * w);
        double ratio = d / d2;

        Console.WriteLine($"{(int)(h * ratio)} {(int)(w * ratio)}");
    }
}