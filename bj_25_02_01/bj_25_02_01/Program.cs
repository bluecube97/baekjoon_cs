internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = input[0];
        int m = input[1];

        int[] aArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] bArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

        long luck = aArr.Sum();

        foreach (var i in bArr)
        {
            if (i == 0)
            {
                continue;
            }
            luck *= i;
        }

        Console.WriteLine(luck);
    }
}