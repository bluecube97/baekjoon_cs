using System.Text;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string[] input = isr.ReadLine().Split().ToArray();
        string s = input[0];
        int k = int.Parse(input[1]);

        s = s.ToLower();

        StringBuilder result = new StringBuilder();
        HashSet<char> used = new HashSet<char>();

        int i = 0;
        while (i < s.Length)
        {
            char current = s[i];
            int count = 0;

            while (i < s.Length && s[i] == current)
            {
                count++;
                i++;
            }

            if (used.Contains(current))
                continue;

            if (count >= k)
                result.Append('1');
            else
                result.Append('0');

            used.Add(current);
        }

        Console.WriteLine(result.ToString());
    }
}