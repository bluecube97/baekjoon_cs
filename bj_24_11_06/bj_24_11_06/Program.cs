internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        int R = int.Parse(input[0]);
        int C = int.Parse(input[1]);

        char[,] card = new char[R * 2, C * 2];

        for (int i = 0; i < R; i++)
        {
            string input2 = Console.ReadLine();

            for (int j = 0; j < C; j++)
            {
                card[i, j] = input2[j];
                card[i, C * 2 - j - 1] = input2[j];
                card[R * 2 - i - 1, j] = input2[j];
                card[R * 2 - i - 1, C * 2 - j - 1] = input2[j];
            }
        }

        input = Console.ReadLine().Split(' ');

        for (int i = 0; i < R * 2; i++)
        {
            for (int j = 0; j < C * 2; j++)
            {
                if (i == int.Parse(input[0]) - 1 && j == int.Parse(input[1]) - 1)
                {
                    if (card[i, j] == '#')
                    {
                        card[i, j] = '.';
                    }
                    else
                    {
                        card[i, j] = '#';
                    }
                }
                Console.Write(card[i, j]);
            }

            Console.WriteLine();
        }
    }
}