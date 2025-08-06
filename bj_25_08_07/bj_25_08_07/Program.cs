internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        List<(int solved, int penalty)> teams = new List<(int, int)>
        {
            (12, 1600),
            (11, 894),
            (11, 1327),
            (10, 1311),
            (9, 1004),
            (9, 1178),
            (9, 1357),
            (8, 837),
            (7, 1055),
            (6, 556),
            (6, 773)
        };

        int n = int.Parse(isr.ReadLine());

        (int, int) team = teams[n - 1];
        Console.WriteLine($"{team.Item1} {team.Item2}");
    }
}