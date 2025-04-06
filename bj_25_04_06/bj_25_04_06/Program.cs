internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        List<Stack<int>> bookStackList = new List<Stack<int>>(m);

        for (int i = 0; i < m; i++)
        {
            int k = int.Parse(isr.ReadLine());
            int[] bookArr = isr.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bookStack = new Stack<int>(bookArr);

            bookStackList.Add(bookStack);
        }

        bool isPossible = true;

        foreach (var stack in bookStackList)
        {
            int prev = int.MinValue;

            while (stack.Count > 0)
            {
                int curr = stack.Pop();
                if (curr < prev)
                {
                    isPossible = false;
                    break;
                }
                prev = curr;
            }

            if (!isPossible) break;
        }

        Console.WriteLine(isPossible ? "Yes" : "No");
    }
}