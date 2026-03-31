internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];
        int k = input[2];
        string s = isr.ReadLine();

        for (int i = 0; i < n; i++)
        {
            if (s[i] == 'R')
            {
                int min = Math.Max(0, i - k);
                int max = Math.Min(n - 1, i + k);

                for (int j = min; j <= max; j++)
                {
                    if (s[j] == '.')
                        s = s.Remove(j, 1).Insert(j, "X");
                }
            }
        }

        int count = s.Count(c => c == 'R');
        count += s.Count(c => c == 'X');
        Console.WriteLine(count > m ? "No" : "Yes");
    }
}