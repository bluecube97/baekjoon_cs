internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string emoji = isr.ReadLine();
        int len = emoji.Length + 2;
        int underBar = 0;

        foreach (var c in emoji)
        {
            if (c == '_')
            {
                underBar++;
            }
        }

        Console.WriteLine(len + underBar * 5);
    }
}