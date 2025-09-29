internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        Dictionary<int, int> count = new Dictionary<int, int>();
        for (int i = 0; i < 5; i++)
        {
            int sock = int.Parse(isr.ReadLine());
            count.TryAdd(sock, 0);
            count[sock]++;
        }

        foreach (var sock in count)
        {
            if (sock.Value % 2 == 1)
            {
                Console.WriteLine(sock.Key);
                break;
            }
        }
    }
}