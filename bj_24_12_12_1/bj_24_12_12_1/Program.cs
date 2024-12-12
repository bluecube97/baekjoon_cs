internal class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int huddle = input[0];
            int jumpHigh = input[1];
            int throwIronBall = input[2];
            int run200M = input[3];
            int jumpLong = input[4];
            int throwSpear = input[5];
            int run800M = input[6];

            huddle = (int)(9.23076 * Math.Pow(26.7 - input[0], 1.835));
            jumpHigh = (int)(1.84523 * Math.Pow(input[1] - 75, 1.348));
            throwIronBall = (int)(56.0211 * Math.Pow(input[2] - 1.5, 1.05));
            run200M = (int)(4.99087 * Math.Pow(42.5 - input[3], 1.81));
            jumpLong = (int)(0.188807 * Math.Pow(input[4] - 210, 1.41));
            throwSpear = (int)(15.9803 * Math.Pow(input[5] - 3.8, 1.04));
            run800M = (int)(0.11193 * Math.Pow(254 - input[6], 1.88));

            int result = huddle + jumpHigh + throwIronBall + run200M + jumpLong + throwSpear + run800M;
            Console.WriteLine(result);
        }
    }
}