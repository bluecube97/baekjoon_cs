internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int n = input[0];
        int m = input[1];
        int l = input[2];

        int ballCount = 0;
        int catchCount = 1;

        LinkedList<int> seat = new LinkedList<int>();

        for (int i = 1; i <= n; i++)
        {
            seat.AddLast(0);
        }

        LinkedListNode<int> node = seat.First;
        node.Value = 1;

        while (catchCount < m)
        {
            if (node.Value % 2 != 1)
            {
                for (int i = 0; i < l; i++)
                {
                    node = node.Previous ?? seat.Last;
                }
            }
            else
            {
                for (int i = 0; i < l; i++)
                {
                    node = node.Next ?? seat.First;
                }
            }

            node.Value++;
            catchCount = node.Value;
            ballCount++;
        }

        Console.WriteLine(ballCount);
    }
}