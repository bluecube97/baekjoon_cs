internal class Program
{
    static void Main(string[] args)
    {
        bool[,] grid = new bool[501, 501];
        int n  = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int[] coord = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int x1 = coord[0];
            int y1 = coord[1];
            int x2 = coord[2];
            int y2 = coord[3];

            for (int x = x1; x < x2; x++)
            {
                for (int y = y1; y < y2; y++)
                {
                    grid[x, y] = true;
                }
            }
        }

        int count = 0;
        for (int x = 0; x < 501; x++)
        {
            for (int y = 0; y < 501; y++)
            {
                if (grid[x, y])
                {
                    count++;
                }
            }
        }

        Console.WriteLine(count);
    }
}