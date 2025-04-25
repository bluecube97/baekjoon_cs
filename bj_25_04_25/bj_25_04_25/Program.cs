internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string mbti = isr.ReadLine();

        if (mbti[0] == 'E')
        {
            Console.Write("I");
        }
        if (mbti[0] == 'I')
        {
            Console.Write("E");
        }
        if (mbti[1] == 'S')
        {
            Console.Write("N");
        }
        if (mbti[1] == 'N')
        {
            Console.Write("S");
        }
        if (mbti[2] == 'T')
        {
            Console.Write("F");
        }
        if (mbti[2] == 'F')
        {
            Console.Write("T");
        }
        if (mbti[3] == 'J')
        {
            Console.Write("P");
        }
        if (mbti[3] == 'P')
        {
            Console.Write("J");
        }
        Console.WriteLine();
    }
}