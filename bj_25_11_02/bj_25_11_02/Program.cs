internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] skh = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int s = skh[0];
        int k = skh[1];
        int h = skh[2];

        if (s + k + h >= 100)
        {
            Console.WriteLine("OK");
        }
        else
        {
            int min = Math.Min(s, Math.Min(k, h));
            if (min == s)
            {
                Console.WriteLine("Soongsil");
            }
            else if (min == k)
            {
                Console.WriteLine("Korea");
            }
            else
            {
                Console.WriteLine("Hanyang");
            }
        }
    }
}