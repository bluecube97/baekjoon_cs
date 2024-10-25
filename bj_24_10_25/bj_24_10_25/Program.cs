class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine()); // 테스트 케이스의 개수

        for (int t = 0; t < T; t++)
        {
            int N = int.Parse(Console.ReadLine()); // 주식 데이터의 일수
            int maxProfit = 0;

            for (int day = 0; day < N; day++)
            {
                // 각 회사의 주식 손익 입력
                string[] profits = Console.ReadLine().Split();
                int profitA = int.Parse(profits[0]);
                int profitB = int.Parse(profits[1]);
                int profitC = int.Parse(profits[2]);

                // 그날 가능한 최대 이익을 추가 (0을 넘지 않으면 주식을 사지 않음)
                int bestProfit = Math.Max(0, Math.Max(profitA, Math.Max(profitB, profitC)));
                maxProfit += bestProfit;
            }

            Console.WriteLine(maxProfit);
        }
    }
}