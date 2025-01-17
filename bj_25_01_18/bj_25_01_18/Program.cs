internal class Program
{
    static void Main(string[] args)
    {
        string date = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        int year = int.Parse(date.Substring(0, 4));
        int month = int.Parse(date.Substring(5, 2));
        int day = int.Parse(date.Substring(8, 2));

        day += n;

        while (day > 30 || month > 12)
        {
            if (day > 30)
            {
                month++;
                day -= 30;
            }
            if (month > 12)
            {
                year++;
                month -= 12;
            }
        }

        Console.WriteLine($"{year}-{month:D2}-{day:D2}");
    }
}