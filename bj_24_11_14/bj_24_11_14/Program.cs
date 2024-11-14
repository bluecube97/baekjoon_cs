internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        float w = input[0];
        float h = input[1];

        float dimension = w * h / 2;
        Console.WriteLine($"{dimension:F1}");;
    }
}