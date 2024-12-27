internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int a = input[0];
        int d = input[1];
        int k = input[2];

        if ((k - a) % d != 0 || (k - a) / d < 0)
        {
            Console.WriteLine("X");
            return;
        }

        Console.WriteLine((k - a) / d + 1);
    }
}