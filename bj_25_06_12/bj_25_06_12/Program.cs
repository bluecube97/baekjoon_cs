internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string s = isr.ReadLine();
        string trueString = "SciComLove";

        int falseCount = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != trueString[i])
            {
                falseCount++;
            }
        }

        Console.WriteLine(falseCount);
    }
}