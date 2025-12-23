internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        string s = isr.ReadLine();

        if (s.Length < 2)
        {
            Console.WriteLine("CE");
            return;
        }

        if (s[0] == '"' && s[^1] == '"')
        {
            string inner = s.Substring(1, s.Length - 2);

            if (inner.Length == 0)
            {
                Console.WriteLine("CE");
            }
            else
            {
                Console.WriteLine(inner);
            }
        }
        else
        {
            Console.WriteLine("CE");
        }
    }
}