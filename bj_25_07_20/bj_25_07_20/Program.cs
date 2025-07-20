internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] formula = isr.ReadLine().Split().ToArray();
            long a = long.Parse(formula[0]);
            long b = long.Parse(formula[2]);
            string op = formula[1];
            long result = long.Parse(formula[4]);

            if (result == calculator(a, b, op))
            {
                Console.WriteLine("correct");
            }
            else
            {
                Console.WriteLine("wrong answer");
            }
        }
    }

    private static long calculator(long a, long b, string op)
    {
        switch (op)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                return a / b;
            default:
                return 0;
        }
    }
}