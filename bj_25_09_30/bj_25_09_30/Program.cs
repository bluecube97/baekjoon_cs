internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        double n = nm[0];
        double m = nm[1];

        int minute = (int) (m / n * 24.0 * 60.0);
        int hour = minute / 60;
        minute %= 60;

        string sHour = hour < 10 ? "0" + hour : hour.ToString();
        string sMinute = minute < 10 ? "0" + minute : minute.ToString();

        Console.WriteLine($"{sHour}:{sMinute}");
    }
}