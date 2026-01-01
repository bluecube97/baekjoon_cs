internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int q = int.Parse(isr.ReadLine());
        for (int i = 0; i < q; i++)
        {
            string s = isr.ReadLine();
            int cnt = 0;

            for (int j = 0; j < s.Length - 2; j++)
            {
                if (s[j].Equals('W') && s[j + 1].Equals('O') && s[j + 2].Equals('W'))
                {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}