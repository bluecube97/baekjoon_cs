internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int perimeter = 0;

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int firstX = input[0];
        int firstY = input[1];
        int prevX = firstX;
        int prevY = firstY;

        for (int i = 1; i < n; i++)
        {
            input = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int x = input[0];
            int y = input[1];

            int distance = Math.Abs(x - prevX) + Math.Abs(y - prevY);
            perimeter += distance;

            prevX = x;
            prevY = y;
        }

        perimeter += Math.Abs(firstX - prevX) + Math.Abs(firstY - prevY);

        Console.WriteLine(perimeter);
    }
}