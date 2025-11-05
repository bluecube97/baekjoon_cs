internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] p = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int[] points = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int index = 1;

        foreach (var person in p)
        {
            if (person == points[0])
            {
                Console.WriteLine(index);
                return;
            }
            index++;
        }

        Console.WriteLine(0);
    }
}