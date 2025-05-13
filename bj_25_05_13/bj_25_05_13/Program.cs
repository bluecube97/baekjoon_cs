internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string s = isr.ReadLine();
        string t = isr.ReadLine();

        for (int i = 0; i < t.Length; i++)
        {
            if (!s.Contains(t[i]))
            {
                Console.Write(t[i]);
            }
        }
    }
}