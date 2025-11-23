internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());

        List<string> promise = new List<string>
        {
            "Never gonna give you up", "Never gonna let you down", "Never gonna run around and desert you",
            "Never gonna make you cry", "Never gonna say goodbye", "Never gonna tell a lie and hurt you",
            "Never gonna stop"
        };

        bool isHacked = false;

        for (int i = 0; i < n; i++)
        {
            string s = isr.ReadLine();

            if (!promise.Contains(s))
            {
                isHacked = true;
            }
        }

        Console.WriteLine(isHacked ? "Yes" : "No");
    }
}