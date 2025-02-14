internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int e = input[0];
        int f = input[1];
        int c = input[2];

        int cola = 0;
        int emptyBottle = e + f;

        while (emptyBottle >= c)
        {
            int drink = emptyBottle / c;
            cola += drink;
            emptyBottle %= c;
            emptyBottle += drink;
        }

        Console.WriteLine(cola);
    }
}