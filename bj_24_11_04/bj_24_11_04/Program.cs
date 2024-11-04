internal class Program
{
    static void Main(string[] args)
    {
        int testCase = int.Parse(Console.ReadLine());

        for (int i = 0; i < testCase; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int c = int.Parse(input[0]);
            int v = int.Parse(input[1]);

            int yourCandy = c / v;
            int remainCandy = c % v;

            Console.WriteLine("You get {0} piece(s) and your dad gets {1} piece(s).", yourCandy, remainCandy);
        }
    }
}