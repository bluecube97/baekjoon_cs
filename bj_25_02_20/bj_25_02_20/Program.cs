internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] vote = new int[2];

        for (int i = 0; i < n; i++)
        {
            int voted = int.Parse(Console.ReadLine());
            vote[voted]++;
        }

        if (vote[0] > vote[1])
        {
            Console.WriteLine("Junhee is not cute!");
        }
        else
        {
            Console.WriteLine("Junhee is cute!");
        }
    }
}