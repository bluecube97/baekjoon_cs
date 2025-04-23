internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string now = isr.ReadLine();
        string start = isr.ReadLine();

        int nowHour = int.Parse(now.Split(':')[0]);
        int nowMinute = int.Parse(now.Split(':')[1]);
        int nowSecond = int.Parse(now.Split(':')[2]);
        int startHour = int.Parse(start.Split(':')[0]);
        int startMinute = int.Parse(start.Split(':')[1]);
        int startSecond = int.Parse(start.Split(':')[2]);

        int nowTotalSeconds = nowHour * 3600 + nowMinute * 60 + nowSecond;
        int startTotalSeconds = startHour * 3600 + startMinute * 60 + startSecond;
        int diff = startTotalSeconds - nowTotalSeconds;

        if (diff < 0)
        {
            diff += 24 * 3600;
        }
        int diffHour = diff / 3600;
        int diffMinute = (diff % 3600) / 60;
        int diffSecond = diff % 60;
        Console.WriteLine($"{diffHour:D2}:{diffMinute:D2}:{diffSecond:D2}");
    }
}