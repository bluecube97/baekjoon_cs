internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string[] input = isr.ReadLine().Split().ToArray();

        string strA = input[0];
        string strB = input[1];

        int a = int.Parse(new string(strA.Reverse().ToArray()));
        int b = int.Parse(new string(strB.Reverse().ToArray()));

        Console.WriteLine(a > b ? a : b);
    }
}