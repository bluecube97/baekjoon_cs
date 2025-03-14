internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        int[] result = new int[3];

        for (int i = 0; i < 3; i++)
        {
            string num = isr.ReadLine();
            int maxLen = 1;
            int curLen = 1;

            for (int j = 1; j < 8; j++)
            {
                if (num[j] == num[j - 1])
                {
                    curLen++;
                }
                else
                {
                    maxLen = Math.Max(maxLen, curLen);
                    curLen = 1;
                }
            }
            maxLen = Math.Max(maxLen, curLen);
            result[i] = maxLen;
        }

        foreach (var num in result)
        {
            Console.WriteLine(num);
        }
    }
}