internal class Program
{
    static void Main()
    {
        int[] nd = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nd[0];
        int d = nd[1];

        for (int i = 0; i < n; i++)
        {
            string str = Console.ReadLine();
            str = rotate(str, d);
            Console.WriteLine(str);
        }
    }

    private static string rotate(string str, int d)
    {
        string result = "";
        foreach (var c in str)
        {
            if (d == 1)
            {
                if (c == 'd')
                {
                    result += 'q';
                }
                else if (c == 'b')
                {
                    result += 'p';
                }
                else if (c == 'p')
                {
                    result += 'b';
                }
                else if (c == 'q')
                {
                    result += 'd';
                }
            }
            else if (d == 2)
            {
                if (c == 'd')
                {
                    result += 'b';
                }
                else if (c == 'b')
                {
                    result += 'd';
                }
                else if (c == 'p')
                {
                    result += 'q';
                }
                else if (c == 'q')
                {
                    result += 'p';
                }
            }
        }
        return result;
    }
}