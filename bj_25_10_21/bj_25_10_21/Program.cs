internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int[] nml = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nml[0];
            int m = nml[1];
            int l = nml[2];

            int[] s = isr.ReadLine().Split().Select(int.Parse).ToArray();

            int freezeTime = l;

            for (int j = 0; j < n; j++)
            {
                if (s[j] == -1)
                    continue;
                freezeTime = Math.Max(freezeTime, m - s[j]);
            }

            if (freezeTime == 1)
                Console.WriteLine("The scoreboard has been frozen with 1 minute remaining.");
            else
                Console.WriteLine("The scoreboard has been frozen with {0} minutes remaining.", freezeTime);
        }
    }
}