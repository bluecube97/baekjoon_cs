internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string s = isr.ReadLine();
        int score = 0;
        int curScore = 0;
        char curChar = 'a';

        foreach (char c in s)
        {
            if (c > curChar)
            {
                curScore++;
                score += curScore;
                curChar = c;
            }
            else
            {
                curScore = 1;
                score += curScore;
                curChar = c;
            }
        }

        Console.WriteLine(score);
    }
}