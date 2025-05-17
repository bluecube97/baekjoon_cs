internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] count = new int[26];
        string line;

        while ((line = isr.ReadLine()) != null)
        {
            foreach (var c in line)
            {
                if (c >= 'a' && c <= 'z')
                {
                    count[c - 'a']++;
                }
            }
        }

        int max = int.MinValue;
        foreach (var i in count)
        {
            max = Math.Max(max, i);
        }

        for (int i = 0; i < count.Length; i++)
        {
            if (count[i] == max)
            {
                Console.Write((char)(i + 'a'));
            }
        }
    }
}