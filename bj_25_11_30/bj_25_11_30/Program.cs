internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        string s = isr.ReadLine();
        int[] alpha = new int[26];

        foreach (var c in s)
        {
            if (c >= 'a' && c <= 'z')
            {
                alpha[c - 'a']++;
            }
        }

        Console.WriteLine(alpha.Max());
    }
}