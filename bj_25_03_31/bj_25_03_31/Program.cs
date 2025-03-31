internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string word = isr.ReadLine();
        int count = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'c')
            {
                if (i + 1 < word.Length && (word[i + 1] == '=' || word[i + 1] == '-'))
                {
                    i++;
                }
            }

            if (word[i] == 'd')
            {
                if (i + 2 < word.Length && word[i + 1] == 'z' && word[i + 2] == '=')
                {
                    i += 2;
                }
                else if (i + 1 < word.Length && word[i + 1] == '-')
                {
                    i++;
                }
            }

            if (word[i] == 'l' || word[i] == 'n')
            {
                if (i + 1 < word.Length && word[i + 1] == 'j')
                {
                    i++;
                }
            }

            if (word[i] == 's' || word[i] == 'z')
            {
                if (i + 1 < word.Length && word[i + 1] == '=')
                {
                    i++;
                }
            }

            count++;
        }

        Console.WriteLine(count);
    }
}