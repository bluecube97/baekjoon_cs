internal class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
        PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

        foreach (int i in arr)
        {
            pq.Enqueue(i, -i);
        }

        Console.WriteLine(pq.Dequeue());
    }
}