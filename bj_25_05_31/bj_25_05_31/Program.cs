internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] time = isr.ReadLine().Split(':').Select(int.Parse).ToArray();
        int nowHour = time[0];
        int nowMinute = time[1];
        int nowSecond = time[2];

        int[] time2 = isr.ReadLine().Split(':').Select(int.Parse).ToArray();
        int throwHour = time2[0];
        int throwMinute = time2[1];
        int throwSecond = time2[2];

        int nowTotalSeconds = nowHour * 3600 + nowMinute * 60 + nowSecond;
        int throwTotalSeconds = throwHour * 3600 + throwMinute * 60 + throwSecond;
        int result = throwTotalSeconds - nowTotalSeconds;

        if (result <= 0)
        {
            result += 24 * 3600;
        }

        int resultHour = result / 3600;
        result %= 3600;
        int resultMinute = result / 60;
        int resultSecond = result % 60;

        Console.WriteLine($"{resultHour:D2}:{resultMinute:D2}:{resultSecond:D2}");
    }
}