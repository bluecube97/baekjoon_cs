internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();

        string start = input[0];
        string end = input[1];

        int startHour = int.Parse(start.Split(':')[0]);
        int startMinute = int.Parse(start.Split(':')[1]);
        int endHour = int.Parse(end.Split(':')[0]);
        int endMinute = int.Parse(end.Split(':')[1]);

        input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int t = int.Parse(input[1]);
        int day = 0;

        for (int i = 0; i <= n; i++)
        {
            startMinute += t;

            while (startMinute >= 60)
            {
                startMinute -= 60;
                startHour++;
            }

            if (startHour > endHour || (startHour >= endHour && startMinute >= endMinute))
            {
                startHour = int.Parse(start.Split(':')[0]);
                startMinute = int.Parse(start.Split(':')[1]);
                day++;
                i--;
            }
        }

        Console.WriteLine(day);
        Console.Write($"{startHour:D2}:{startMinute:D2}");
    }
}