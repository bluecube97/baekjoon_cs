internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];

        int[] limit = new int[100];
        int[] speed = new int[100];

        int index = 0;
        for (int i = 0; i < n; i++)
        {
            input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int length = input[0];
            int maxSpeed = input[1];

            for (int j = 0; j < length; j++)
            {
                limit[index] = maxSpeed;
                index++;
            }
        }

        index = 0;
        for (int i = 0; i < m; i++)
        {
            input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int length = input[0];
            int driveSpeed = input[1];

            for (int j = 0; j < length; j++)
            {
                speed[index] = driveSpeed;
                index++;
            }
        }

        int max = 0;

        for (int i = 0; i < 100; i++)
        {
            int over = speed[i] - limit[i];
            if (over > max)
            {
                max = over;
            }
        }

        Console.WriteLine(max);
    }
}