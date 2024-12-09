internal class Program
{
    static void Main(string[] args)
    {
        var input = new StreamReader(Console.OpenStandardInput());
        var result = new System.Text.StringBuilder();

        int n = int.Parse(input.ReadLine());
        PriorityQueue<(int x, int y), (int y, int x)> pair = new PriorityQueue<(int x, int y), (int y, int x)>(n);

        for (int i = 0; i < n; i++)
        {
            string[] line = input.ReadLine().Split();

            int x = int.Parse(line[0]);
            int y = int.Parse(line[1]);

            pair.Enqueue((x, y), (y, x));
        }

        for (int i = 0; i < n; i++)
        {
            (int x, int y) = pair.Dequeue();
            result.AppendLine(x + " " + y);
        }
        Console.WriteLine(result.ToString());
    }
}