internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        (int, int) s = (input[0], input[1]);
        input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        (int, int) e = (input[0], input[1]);
        input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        (int, int) p = (input[0], input[1]);

        // x 또는 y가 같은 직선 경로인 경우
        if (s.Item1 == e.Item1)
        {
            // 수직 이동
            bool blocked = (p.Item1 == s.Item1) &&
                           ((p.Item2 > Math.Min(s.Item2, e.Item2)) &&
                            (p.Item2 < Math.Max(s.Item2, e.Item2)));

            Console.WriteLine(blocked ? 2 : 0);
        }
        else if (s.Item2 == e.Item2)
        {
            // 수평 이동
            bool blocked = (p.Item2 == s.Item2) &&
                           ((p.Item1 > Math.Min(s.Item1, e.Item1)) &&
                            (p.Item1 < Math.Max(s.Item1, e.Item1)));

            Console.WriteLine(blocked ? 2 : 0);
        }
        else
        {
            // 대각선 형태
            Console.WriteLine(1);
        }
    }
}