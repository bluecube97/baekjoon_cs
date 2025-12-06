internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string line = isr.ReadLine();
        string vowels = "aeiou";

        for (int i = 0; i < line.Length; i++)
        {
            Console.Write(line[i]);

            if (vowels.Contains(line[i]))
            {
                i += 2;
            }
        }
    }
}