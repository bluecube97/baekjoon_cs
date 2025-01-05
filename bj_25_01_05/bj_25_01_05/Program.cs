internal class Program
{
    static void Main(string[] args)
    {
        string s = Console.ReadLine();
        string k = Console.ReadLine();

        int sLen = s.Length;

        for (int i = 0; i < sLen; i++)
        {
            if (!((s[i] >= 'a' && s[i] <= 'z') || (s[i] >= 'A' && s[i] <= 'Z')))
            {
                s = s.Remove(i, 1);
                i--;
                sLen--;
            }
        }

        if (s.Contains(k))
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}