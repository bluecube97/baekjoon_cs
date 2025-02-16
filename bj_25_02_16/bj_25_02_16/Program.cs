internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        string w = input[0];
        int n = int.Parse(input[1]);
        int[,] arr = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = nums[j];
            }
        }

        if (w.Equals("L") || w.Equals("R"))
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (arr[i, j] == 2)
                    {
                        Console.Write("5 ");
                    }
                    else if (arr[i, j] == 5)
                    {
                        Console.Write("2 ");
                    }
                    else if (arr[i, j] == 1)
                    {
                        Console.Write("1 ");
                    }
                    else if (arr[i, j] == 8)
                    {
                        Console.Write("8 ");
                    }
                    else
                    {
                        Console.Write("? ");
                    }
                }
                Console.WriteLine();
            }
        }
        else if (w.Equals("U") || w.Equals("D"))
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] == 2)
                    {
                        Console.Write("5 ");
                    }
                    else if (arr[i, j] == 5)
                    {
                        Console.Write("2 ");
                    }
                    else if (arr[i, j] == 1)
                    {
                        Console.Write("1 ");
                    }
                    else if (arr[i, j] == 8)
                    {
                        Console.Write("8 ");
                    }
                    else
                    {
                        Console.Write("? ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}