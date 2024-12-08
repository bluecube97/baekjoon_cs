internal class Program
{
    static void Main(string[] args)
    {
        int[] prompt = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int N = prompt[0];
        int M = prompt[1];
        int[] status = Console.ReadLine().Split().Select(int.Parse).ToArray();

        for (int i = 0; i < M; i++)
        {
            prompt = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = prompt[0];
            int b = prompt[1];
            int c = prompt[2];
            b--;

            switch (a)
            {
                case 1:
                    status[b] = c;
                    break;
                case 2:
                    for (int j = b; j < c; j++)
                    {
                        if (status[j] == 1)
                        {
                            status[j] = 0;
                        }
                        else
                        {
                            status[j] = 1;
                        }
                    }
                    break;
                case 3:
                    for (int j = b; j < c; j++)
                    {
                        status[j] = 0;
                    }
                    break;
                case 4:
                    for (int j = b; j < c; j++)
                    {
                        status[j] = 1;
                    }
                    break;
            }
        }
        Console.WriteLine(string.Join(" ", status));
    }
}