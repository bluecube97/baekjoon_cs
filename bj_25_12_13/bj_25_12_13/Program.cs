internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int m = int.Parse(isr.ReadLine());
        double rotationTimeD = 1;
        long rotationTime = 1;
        bool rotateDirection = true; // true: 시계방향, false: 반시계방향

        for (int i = 0; i < m; i++)
        {
            long[] info = isr.ReadLine().Split().Select(long.Parse).ToArray();
            long a = info[0];
            long b = info[1];
            long s = info[2];

            double mag = 1.0 * b / a;

            rotationTimeD *= mag;
            rotationTime = (long)Math.Round(rotationTimeD, MidpointRounding.AwayFromZero);
            if (s % 2 == 1)
            {
                rotateDirection = !rotateDirection;
            }
        }

        Console.WriteLine("{0} {1}", rotateDirection ? 0 : 1, rotationTime);
    }
}