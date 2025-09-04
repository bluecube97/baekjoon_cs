internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        bool[] isGlobal = new bool[3];

        for (int i = 0; i < 3; i++)
        {
            string sentence = isr.ReadLine();
            if (sentence[0] == 'l' && !isGlobal[0])
            {
                isGlobal[0] = true;
            }
            if (sentence[0] == 'k' && !isGlobal[1])
            {
                isGlobal[1] = true;
            }
            if (sentence[0] == 'p' && !isGlobal[2])
            {
                isGlobal[2] = true;
            }
        }

        Console.WriteLine(isGlobal.All(x => x) ? "GLOBAL" : "PONIX");
    }
}