internal class Program
{
    static int N;
    static long[] tree;

    static void Update(int index, long val)
    {
        while (index <= N)
        {
            tree[index] += val;
            index += index & -index;
        }
    }

    static long Query(int index)
    {
        long sum = 0;
        while (index > 0)
        {
            sum += tree[index];
            index -= index & -index;
        }

        return sum;
    }

    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] input = isr.ReadLine().Split().Select(int.Parse).ToArray();
        N = input[0];
        int q = input[1];

        tree = new long[N + 1];

        for (int i = 0; i < q; i++)
        {
            long[] query = isr.ReadLine().Split().Select(long.Parse).ToArray();
            int type = (int)query[0];
            int p = (int)query[1];
            long num = query[2];

            if (type == 1)
            {
                Update(p, num);
            }
            else if (type == 2)
            {
                long sum = Query((int)num) - Query(p - 1);
                Console.WriteLine(sum);
            }
        }
    }
}