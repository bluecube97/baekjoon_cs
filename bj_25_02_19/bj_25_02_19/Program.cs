internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int k = input[0];
        int n = input[1];
        int m = input[2];

        Console.WriteLine(k * n - m > 0 ? k * n - m : 0);
    }
}