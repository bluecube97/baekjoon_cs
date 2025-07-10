internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        string answer = isr.ReadLine();

        int bigdata = answer.Count(c => c == 'b');
        int security = answer.Count(c => c == 's');

        if (bigdata == security)
        {
            Console.WriteLine("bigdata? security!");
            return;
        }
        Console.WriteLine(bigdata > security ? "bigdata?" : "security!");
    }
}