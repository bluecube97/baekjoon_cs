internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int R = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        (int L, int W) = FindRoomSize(R, B);

        Console.WriteLine($"{L} {W}");
    }

    static (int, int) FindRoomSize(int R, int B)
    {
        int totalTiles = R + B;

        for (int L = 3; L <= totalTiles; L++)
        {
            if (totalTiles % L == 0)
            {
                int W = totalTiles / L;

                if (2 * (L + W) - 4 == R && (L - 2) * (W - 2) == B)
                {
                    return L >= W ? (L, W) : (W, L);
                }
            }
        }

        return (0, 0);
    }
}