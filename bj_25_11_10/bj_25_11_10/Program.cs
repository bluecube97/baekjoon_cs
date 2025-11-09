internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        string[] s = isr.ReadLine().Split().ToArray();

        char firstChar = s[0][0];

        for (int i = 1; i < n; i++)
        {
            if (s[i][0] != firstChar)
            {
                Console.WriteLine(0);
                return;
            }
        }

        Console.WriteLine(1);
    }
}