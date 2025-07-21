internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string s = isr.ReadLine();

        var gradeMap = new Dictionary<string, double>
        {
            { "A+", 4.5 },
            { "A", 4.0 },
            { "B+", 3.5 },
            { "B", 3.0 },
            { "C+", 2.5 },
            { "C", 2.0 },
            { "D+", 1.5 },
            { "D", 1.0 },
            { "F", 0.0 },
        };

        double score = 0.0;
        int scoreCount = 0;

        for (int i = 0; i < s.Length;)
        {
            string grade;

            if (i + 1 < s.Length && s[i + 1] == '+')
            {
                grade = s.Substring(i, 2);
                i += 2;
            }
            else
            {
                grade = s[i].ToString();
                i += 1;
            }

            score += gradeMap[grade];
            scoreCount++;
        }

        Console.WriteLine($"{score / scoreCount:F5}");
    }
}