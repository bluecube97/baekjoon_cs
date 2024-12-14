internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        PriorityQueue<string, int> question = new PriorityQueue<string, int>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            string title = input[0];
            int level = int.Parse(input[1]);

            question.Enqueue(title, level);
        }

        Console.WriteLine(question.Dequeue());
    }
}