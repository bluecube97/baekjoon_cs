internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string s = isr.ReadLine();

        if (s[0] == '(' && s[2] == ')')
        {
            Console.WriteLine(0);
        }
        else if (s[0] == ')' && s[2] == '(')
        {
            Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(1);
        }
    }
}