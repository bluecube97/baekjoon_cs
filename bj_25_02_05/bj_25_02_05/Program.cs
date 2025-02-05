internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int a = input[0];
        int b = input[1];

        Console.WriteLine(a / 2 < b ? a / 2 : b);
    }
}