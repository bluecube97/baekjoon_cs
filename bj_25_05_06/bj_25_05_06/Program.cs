internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string input = isr.ReadLine();

        int m = 0;
        int o = 0;
        int b = 0;
        int i = 0;
        int s = 0;

        foreach (char c in input)
        {
            if (c == 'M')
                m++;
            else if (c == 'O')
                o++;
            else if (c == 'B')
                b++;
            else if (c == 'I')
                i++;
            else if (c == 'S')
                s++;
        }

        if (m == 0 || o == 0 || b == 0 || i == 0 || s == 0)
        {
            Console.WriteLine("NO");
        }
        else
        {
            Console.WriteLine("YES");
        }
    }
}