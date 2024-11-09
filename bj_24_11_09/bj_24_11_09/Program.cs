internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int m = input[0];
        int seed = input[1];
        int x1 = input[2];
        int x2 = input[3];

        for (int a = 0; a < m; a++)
        {
            for (int c = 0; c < m; c++)
            {
                if (x2 == (a * x1 + c) % m && x1 == (a * seed + c) % m)
                {
                    Console.WriteLine($"{a} {c}");
                    return;
                }
            }
        }
    }
}