internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int white = 0;
        int black = 0;

        for (int j = 0; j < 8; j++)
        {
            string input = isr.ReadLine();
            foreach (var c in input)
            {
                switch (c)
                {
                    case 'P':
                        white += 1;
                        break;
                    case 'p':
                        black += 1;
                        break;
                    case 'N':
                        white += 3;
                        break;
                    case 'n':
                        black += 3;
                        break;
                    case 'B':
                        white += 3;
                        break;
                    case 'b':
                        black += 3;
                        break;
                    case 'R':
                        white += 5;
                        break;
                    case 'r':
                        black += 5;
                        break;
                    case 'Q':
                        white += 9;
                        break;
                    case 'q':
                        black += 9;
                        break;
                }
            }
        }

        Console.WriteLine(white - black);
    }
}