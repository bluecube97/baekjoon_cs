internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int totalCost = 0;

        for (int i = 0; i < n; i++)
        {
            string info = isr.ReadLine();
            string[] call = info.Split();
            string[] time = call[0].Split(':');

            int hour = int.Parse(time[0]);
            int minute = int.Parse(time[1]);
            int duration = int.Parse(call[1]);

            for (int d = 0; d < duration; d++)
            {
                if (hour >= 7 && hour < 19)
                    totalCost += 10;
                else
                    totalCost += 5;

                minute++;

                if (minute == 60)
                {
                    minute = 0;
                    hour++;
                    if (hour == 24)
                        hour = 0;
                }
            }
        }

        Console.WriteLine(totalCost);
    }
}