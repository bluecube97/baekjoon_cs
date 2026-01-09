internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int p = int.Parse(isr.ReadLine());

        for (int i = 0; i < p; i++)
        {
            string[] input = isr.ReadLine().Split().ToArray();
            int n = int.Parse(input[0]);
            double d = double.Parse(input[1]);  // 철로의 길이
            double a = double.Parse(input[2]);  // a기차의 속도
            double b = double.Parse(input[3]);  // b기차의 속도
            double f = double.Parse(input[4]);  // 파리의 속도

            // a기차와 b기차가 충돌하는 데 걸리는 시간
            double time = d / (a + b);
            // 파리가 이동한 거리
            double distance = f * time;
            Console.WriteLine($"{n} {distance:F6}");
        }
    }
}