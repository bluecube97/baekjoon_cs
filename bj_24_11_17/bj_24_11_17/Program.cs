internal class Program
{
    private static int recursionCount = 0;

    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCase; i++)
        {
            recursionCount = 0;
            string input = Console.ReadLine();
            Console.Write(isPalindrome(input));
            Console.WriteLine(" " + recursionCount);
        }
    }
    
    static int recursion(string s, int l, int r)
    {
        recursionCount++;
        if (l >= r)
        {
            return 1;
        }
        else if (s[l] != s[r])
        {
            return 0;
        }
        else
        {
            return recursion(s, l + 1, r - 1);
        }
    }

    static int isPalindrome(string s)
    {
        return recursion(s, 0, s.Length - 1);
    }
}