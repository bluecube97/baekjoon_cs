internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string str = isr.ReadLine();
        int holeCount = 0;

        foreach (var c in str)
        {
            switch (c)
            {
                case 'A':
                case 'a':
                case 'b':
                case 'D':
                case 'd':
                case 'e':
                case 'g':
                case 'O':
                case 'o':
                case 'P':
                case 'p':
                case 'Q':
                case 'q':
                case 'R':
                    holeCount += 1;
                    break;
                case 'B':
                    holeCount += 2;
                    break;
                case '@':
                    holeCount += 1;
                    break;
            }
        }

        Console.WriteLine(holeCount);
    }
}