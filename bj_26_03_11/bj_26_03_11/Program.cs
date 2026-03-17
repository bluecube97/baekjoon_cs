internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string[] input = isr.ReadLine().Split().ToArray();
        int m = int.Parse(input[0]);
        int n = int.Parse(input[1]);

        string nowDir = "xPlus";
        (int, int) nowPos = (0, 0);

        for (int i = 0; i < n; i++)
        {
            input = isr.ReadLine().Split().ToArray();
            string query = input[0];
            int num = int.Parse(input[1]);

            switch (query)
            {
                case "MOVE":
                    nowPos = MoveTo(num, nowDir, nowPos);
                    break;
                case "TURN":
                    nowDir = Turn(nowDir, num);
                    break;
            }

            if (nowPos.Item1 < 0 || nowPos.Item1 > m || nowPos.Item2 < 0 || nowPos.Item2 > m)
            {
                Console.WriteLine(-1);
                return;
            }
        }

        Console.WriteLine($"{nowPos.Item1} {nowPos.Item2}");
    }

    private static (int, int) MoveTo(int dist, string nowDir, (int, int) nowPos)
    {
        return nowDir switch
        {
            "xPlus" => (nowPos.Item1 + dist, nowPos.Item2),
            "xMinus" => (nowPos.Item1 - dist, nowPos.Item2),
            "yPlus" => (nowPos.Item1, nowPos.Item2 + dist),
            "yMinus" => (nowPos.Item1, nowPos.Item2 - dist),
            _ => (0, 0)
        };
        /*switch (nowDir)
        {
            case "xPlus":
                return (nowPos.Item1 + dist, nowPos.Item2);
            case "xMinus":
                return (nowPos.Item1 - dist, nowPos.Item2);
            case "yPlus":
                return (nowPos.Item1, nowPos.Item2 + dist);
            case "yMinus":
                return (nowPos.Item1, nowPos.Item2 - dist);
            default:
                return (0, 0);
        }*/
    }

    private static string Turn(string nowDir, int num)
    {
        return nowDir switch
        {
            "xPlus" => num == 0 ? "yPlus" : "yMinus",
            "xMinus" => num == 0 ? "yMinus" : "yPlus",
            "yPlus" => num == 0 ? "xMinus" : "xPlus",
            "yMinus" => num == 0 ? "xPlus" : "xMinus",
            _ => ""
        };
        /*switch (nowDir)
        {
            case "xPlus":
                return num == 0 ? "yPlus" : "yMinus";
            case "xMinus":
                return num == 0 ? "yMinus" : "yPlus";
            case "yPlus":
                return num == 0 ? "xMinus" : "xPlus";
            case "yMinus":
                return num == 0 ? "xPlus" : "xMinus";
            default:
                return "";
        }*/
    }
}