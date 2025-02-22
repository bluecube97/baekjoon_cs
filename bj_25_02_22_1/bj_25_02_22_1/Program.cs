internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];
            int c = input[2];
            int d = input[3];

            if (a == 0 && b == 0 && c == 0 && d == 0)
            {
                break;
            }

            Console.WriteLine("{0} {1}", c - b, d - a);
        }
    }
}