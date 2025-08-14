internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int num = 1;

        while (true)
        {
            string[] input = isr.ReadLine().Split().ToArray();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[2]);
            string op = input[1];

            if (op == "E")
                break;

            string result = operating(a, b, op);
            Console.WriteLine($"Case {num}: {result}");
            num++;
        }
    }

    private static string operating(int a, int b, string op)
    {
        return op switch
        {
            ">" => a > b ? "true" : "false",
            ">=" => a >= b ? "true" : "false",
            "<" => a < b ? "true" : "false",
            "<=" => a <= b ? "true" : "false",
            "==" => a == b ? "true" : "false",
            "!=" => a != b ? "true" : "false",
            _ => "inv"
        };
    }
}