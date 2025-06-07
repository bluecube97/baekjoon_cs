internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string s = isr.ReadLine();
            int[] alphabet = new int[26];
            int sum = 0;

            foreach (var c in s)
            {
                alphabet[c - 'A']++;
            }

            for (int j = 0; j < 26; j++)
            {
                if (alphabet[j] == 0)
                {
                    sum += j + 'A';
                }
            }

            Console.WriteLine(sum);
        }
    }
}