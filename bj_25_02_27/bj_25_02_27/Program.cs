internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "#")
            {
                break;
            }

            int strLen = input.Length;
            int sum = 0;

            for (int i = 0; i < strLen; i++)
            {
                sum += getNum(input[i]) * (int)Math.Pow(8, strLen - i - 1);
            }

            Console.WriteLine(sum);
        }
    }

    private static int getNum(char c)
    {
        return c switch
        {
            '-' => 0,
            '\\' => 1,
            '(' => 2,
            '@' => 3,
            '?' => 4,
            '>' => 5,
            '&' => 6,
            '%' => 7,
            '/' => -1,
            _ => 0
        };
    }
}