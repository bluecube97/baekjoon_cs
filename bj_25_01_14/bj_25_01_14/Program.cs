internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int m = input[0];
        int n = input[1];

        PriorityQueue<string, string> numQueue = new PriorityQueue<string, string>();

        for (int i = m; i <= n; i++)
        {
            string num = i.ToString();
            string str = NumToString(num);
            numQueue.Enqueue(num, str);
        }

        for (int i = 1; i <= n - m + 1; i++)
        {
            Console.Write(numQueue.Dequeue());
            if (i % 10 != 0)
            {
                Console.Write(" ");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }

    private static string NumToString(string input)
    {
        string result = "";
        foreach (var c in input)
        {
            switch (c)
            {
                case '0':
                    result += "zero";
                    break;
                case '1':
                    result += "one";
                    break;
                case '2':
                    result += "two";
                    break;
                case '3':
                    result += "three";
                    break;
                case '4':
                    result += "four";
                    break;
                case '5':
                    result += "five";
                    break;
                case '6':
                    result += "six";
                    break;
                case '7':
                    result += "seven";
                    break;
                case '8':
                    result += "eight";
                    break;
                case '9':
                    result += "nine";
                    break;
            }

            result += " ";
        }

        return result.Trim();
    }
}