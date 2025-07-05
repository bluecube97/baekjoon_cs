internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (true)
        {
            int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int a = input[0];
            int b = input[1];
            int c = input[2];

            if (a == 0 && b == 0 && c == 0)
                break;

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Equilateral");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("Isosceles");
                }
                else
                {
                    Console.WriteLine("Scalene");
                }
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}