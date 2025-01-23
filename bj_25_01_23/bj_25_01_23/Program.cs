internal class Program
{
    static void Main(string[] args)
    {
        int[] height = new int[9];
        List<int> result = new List<int>();
        for (int i = 0; i < 9; i++)
        {
            height[i] = int.Parse(Console.ReadLine());
        }

        int heightSum = height.Sum();

        for (int i = 0; i < 9; i++)
        {
            for (int j = i + 1; j < 9; j++)
            {
                if (heightSum - height[i] - height[j] == 100)
                {
                    for (int k = 0; k < 9; k++)
                    {
                        if (k == i || k == j)
                        {
                            continue;
                        }

                        result.Add(height[k]);
                    }

                    result.Sort();
                    foreach (var resultHeight in result)
                    {
                        Console.WriteLine(resultHeight);
                    }
                    return;
                }
            }
        }
    }
}