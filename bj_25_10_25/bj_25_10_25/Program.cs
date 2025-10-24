internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        char[] s = isr.ReadLine().ToCharArray();
        Array.Reverse(s);

        if (s[0] == 'n' || s[0] == 's' || s[0] == 'a' || s[0] == 'e' || s[0] == 'i' || s[0] == 'o' || s[0] == 'u')
        {
            bool isSecond = false;
            int count = 0;
            foreach (var c in s)
            {
                if (isSecond && (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u'))
                {
                    count++;
                    Console.WriteLine(s.Length - count + 1);
                    return;
                }
                else if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    isSecond = true;
                    count++;
                }
                else
                {
                    count++;
                }
            }
        }
        else
        {
            int count = 0;
            foreach (var c in s)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    count++;
                    Console.WriteLine(s.Length - count + 1);
                    return;
                }
                else
                {
                    count++;
                }
            }
        }

        Console.WriteLine(-1);
    }
}