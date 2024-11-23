internal class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] interest = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] myView = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int allSum = 0;
        int mySum = 0;

        foreach (var i in interest)
        {
            allSum += i;
        }

        int index = 0;

        foreach (var i in interest)
        {
            if (myView[index] == 0)
            {
                mySum += i;
            }
            index++;
        }

        Console.WriteLine(allSum);
        Console.WriteLine(mySum);
    }
}