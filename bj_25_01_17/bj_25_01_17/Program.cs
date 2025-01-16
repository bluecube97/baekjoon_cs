internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];
        int k = input[2];

        int x = k / m;
        int y = k % m;

        Console.WriteLine($"{x} {y}");
    }
}