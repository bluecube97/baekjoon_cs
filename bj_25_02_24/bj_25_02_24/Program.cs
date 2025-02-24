internal class Program
{
    static void Main(string[] args)
    {
        var inputStreamReader = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(inputStreamReader.ReadLine());
        Queue<(int, int)> waitLine = new Queue<(int, int)>();   // 학생 대기줄

        List<int> a = new List<int>();
        List<int> b = new List<int>();
        List<int> c = new List<int>();

        for (int i = 0; i < n; i++)
        {
            int[] s = inputStreamReader.ReadLine().Split().Select(int.Parse).ToArray();

            if (s[0] == 1)  // 학생이 식당에 도착
            {
                waitLine.Enqueue((s[1], s[2])); // 대기줄에 학생정보 추가
            }

            if (s[0] == 2)  // 메뉴가 나옴
            {
                (int, int) nowWait = waitLine.Dequeue();    // 가장 먼저 도착한 학생의 정보
                if (nowWait.Item2 == s[1])  // 학생이 좋아하는 메뉴
                {
                    a.Add(nowWait.Item1);   // 리스트에 추가
                }
                else  // 학생이 싫어하는 메뉴
                {
                    b.Add(nowWait.Item1);   // 리스트에 추가
                }
            }
        }

        while (waitLine.Any())
        {
            c.Add(waitLine.Dequeue().Item1);    // 리스트에 추가
        }

        a.Sort();
        b.Sort();
        c.Sort();

        Console.WriteLine(a.Count == 0 ? "None" : string.Join(" ", a));
        Console.WriteLine(b.Count == 0 ? "None" : string.Join(" ", b));
        Console.WriteLine(c.Count == 0 ? "None" : string.Join(" ", c));
    }
}