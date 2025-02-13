internal class Program
{
    static void Main(string[] args)
    {
        float[] input = Console.ReadLine().Split().Select(float.Parse).ToArray();
        float a = input[0];
        float b = input[1];

        Console.WriteLine(a - a * b / 100 < 100 ? 1 : 0);
    }
}