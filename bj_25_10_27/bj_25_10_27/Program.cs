internal class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int time = 0;
        char current = 'A';

        foreach (char target in input)
        {
            int curIndex = current - 'A';
            int targetIndex = target - 'A';

            int forward = (targetIndex - curIndex + 26) % 26;
            int backward = (curIndex - targetIndex + 26) % 26;

            time += Math.Min(forward, backward);
            current = target;
        }

        Console.WriteLine(time);
    }
}