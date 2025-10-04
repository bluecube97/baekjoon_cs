internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        Dictionary<string, (bool solved, int wrongCount, int solvedTime)> problems = new();

        int solvedCount = 0;
        int penalty = 0;

        while (true)
        {
            string log = isr.ReadLine();
            if (log == "-1") break;

            string[] logs = log.Split().ToArray();
            int time = int.Parse(logs[0]);
            string problem = logs[1];
            string isSolved = logs[2];

            if (!problems.ContainsKey(problem))
            {
                problems[problem] = (false, 0, 0);
            }

            var state = problems[problem];

            if (isSolved == "wrong")
            {
                if (!state.solved)
                {
                    state.wrongCount++;
                }
            }
            else if (isSolved == "right")
            {
                if (!state.solved)
                {
                    state.solved = true;
                    state.solvedTime = time;

                    solvedCount++;
                    penalty += time + state.wrongCount * 20;
                }
            }

            problems[problem] = state;
        }
        Console.WriteLine($"{solvedCount} {penalty}");
    }
}