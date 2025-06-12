internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string[] input = isr.ReadLine().Split().ToArray();

        int a = int.Parse(input[0]), b = int.Parse(input[2]), c = int.Parse(input[4]);
        string oper1 = input[1], oper2 = input[3];

        int result1, result2;

        result1 = calc(a, b, oper1);
        result1 = calc(result1, c, oper2);

        result2 = calc(b, c, oper2);
        result2 = calc(a, result2, oper1);

        if (result1 > result2)
        {
            Console.WriteLine(result2);
            Console.WriteLine(result1);
        }
        else
        {
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }

    private static int calc(int a, int b, string oper)
    {
        if (oper == "+")
        {
            return a + b;
        }
        else if (oper == "-")
        {
            return a - b;
        }
        else if (oper == "*")
        {
            return a * b;
        }
        else
        {
            return a / b;
        }
    }
}