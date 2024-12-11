internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int h = input[0];
        int i = input[1];
        int a = input[2];
        int r = input[3];
        int c = input[4];

        Console.WriteLine(h * i - a * r * c);
    }
}