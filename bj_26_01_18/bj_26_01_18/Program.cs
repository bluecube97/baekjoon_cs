internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        string s = isr.ReadLine();
        
        int count = 1;

        for (int i = 0; i < n - 1; i++)
        {
            if (Math.Abs(s[i] - s[i + 1]) == 1)
            {
                count++;
                if (count >= 5)
                {
                    Console.WriteLine("YES");
                    return;
                }
            }
            else
            {
                count = 1;
            }
        }

        Console.WriteLine("NO");
    }
}