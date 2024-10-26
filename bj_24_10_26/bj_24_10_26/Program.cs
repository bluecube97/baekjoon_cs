internal class Program
{
    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());

        double blasterRifle = 350.34;
        double visionSensor = 230.90;
        double hearingSensor = 190.55;
        double arm = 125.30;
        double leg = 180.90;

        for (int i = 0; i < testCase; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int blasterRifleCount = int.Parse(input[0]);
            int visionSensorCount = int.Parse(input[1]);
            int hearingSensorCount = int.Parse(input[2]);
            int armCount = int.Parse(input[3]);
            int legCount = int.Parse(input[4]);

            double total = blasterRifle * blasterRifleCount + visionSensor * visionSensorCount +
                           hearingSensor * hearingSensorCount + arm * armCount + leg * legCount;
            Console.WriteLine("$" + total.ToString("F2"));
        }
    }
}