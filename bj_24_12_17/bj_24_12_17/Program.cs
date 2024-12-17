internal class Program
{
    static void Main(string[] args)
    {
        int T = int.Parse(Console.ReadLine());

        for (int i = 0; i < T; i++)
        {
            int n = int.Parse(Console.ReadLine());
            bool isLoop = false;
            int[] tuple = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int[]> tupleList = new List<int[]>();
            tupleList.Add(tuple.ToArray());

            for (int j = 0; j < 1000; j++)
            {
                if (tuple.All(x => x == 0))
                {
                    isLoop = false;
                    break;
                }

                int[] newTuple = new int[n];
                for (int k = 0; k < n; k++)
                {
                    newTuple[k] = Math.Abs(tuple[k] - tuple[(k + 1) % n]);
                }

                if (tupleList.Any(x => x.SequenceEqual(newTuple)))
                {
                    isLoop = true;
                    break;
                }

                tupleList.Add(newTuple.ToArray());
                tuple = newTuple;
            }

            Console.WriteLine(!isLoop ? "ZERO" : "LOOP");
        }
    }
}