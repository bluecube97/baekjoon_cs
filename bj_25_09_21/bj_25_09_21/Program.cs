internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string str = isr.ReadLine();
        foreach (var c in str)
        {
            if (c >= 'a' && c <= 'z')
            {
                Console.Write((char)(c - 32));
            }
            else if (c >= 'A' && c <= 'Z')
            {
                Console.Write((char)(c + 32));
            }
        }

        Console.WriteLine();
    }
}