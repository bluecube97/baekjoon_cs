internal class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string key = Console.ReadLine();

        string result = "";

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                result += ' ';
                continue;
            }

            int keyIndex = i % key.Length;
            int c = str[i] - key[keyIndex] + 'a' - 1;
            if (c < 'a') c += 26;
            result += (char)c;
        }

        Console.WriteLine(result);
    }
}