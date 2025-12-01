internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        List<List<char>> board = new List<List<char>>();

        for (int i = 0; i < 5; i++)
        {
            var line = isr.ReadLine();
            board.Add(line.ToList());
        }

        for (int col = 0; col < 15; col++)
        {
            for (int row = 0; row < 5; row++)
            {
                if (col < board[row].Count)
                {
                    Console.Write(board[row][col]);
                }
            }
        }
    }
}