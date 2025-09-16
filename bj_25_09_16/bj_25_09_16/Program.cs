internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        char[] s = isr.ReadLine().ToCharArray();

        List<int> posP = new List<int>();
        List<int> posC = new List<int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'P') posP.Add(i);
            else if (s[i] == 'C') posC.Add(i);
        }

        int k = Math.Min(posP.Count, posC.Count);
        for (int i = 0; i < k; i++)
        {
            int pIdx = posP[i];
            int cIdx = posC[i];
            (s[pIdx], s[cIdx]) = (s[cIdx], s[pIdx]);
        }

        Console.WriteLine(new string(s));
    }
}