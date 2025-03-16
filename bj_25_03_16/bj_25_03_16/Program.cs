internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            int k = int.Parse(isr.ReadLine());
            string[] word = new string[k];
            string result = string.Empty;
            bool isFound = false;
            for (int j = 0; j < k; j++)
            {
                word[j] = isr.ReadLine();
            }

            for (int j = 0; j < k; j++)
            {
                for (int l = j + 1; l < k; l++)
                {
                    string testWord = word[j] + word[l];
                    if (testWord.Equals(new string(testWord.Reverse().ToArray())))
                    {
                        result = testWord;
                        isFound = true;
                    }

                    testWord = word[l] + word[j];
                    if (testWord.Equals(new string(testWord.Reverse().ToArray())))
                    {
                        result = testWord;
                        isFound = true;
                    }
                }
            }

            Console.WriteLine(isFound ? result : "0");
        }
    }
}