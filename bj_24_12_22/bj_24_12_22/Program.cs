internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] pink = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] sky = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int pinkSum = pink.Sum();
        int skySum = sky.Sum();

        Console.WriteLine(skySum + " " + pinkSum);
    }
}