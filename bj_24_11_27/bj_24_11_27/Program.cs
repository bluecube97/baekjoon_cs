internal class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];
            int c = input[2];

            int count = 0;

            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    for (int z = 1; z <= c; z++)
                    {
                        if (x % y == y % z && y % z == z % x)
                        {
                            count++;
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}