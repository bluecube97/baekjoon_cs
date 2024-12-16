internal class Program
{
    static void Main(string[] args)
    {
        var inputQuestion = new StreamReader(Console.OpenStandardInput());
        while (inputQuestion.Peek() != -1)
        {
            string[] input = inputQuestion.ReadLine().Split();

            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int roomCount = m - n + 1;

            for (int i = n; i <= m; i++)
            {
                bool[] test = new bool[10];
                string roomNumber = i.ToString();

                foreach (var c in roomNumber)
                {
                    if (test[int.Parse(c.ToString())])
                    {
                        roomCount--;
                        break;
                    }

                    test[int.Parse(c.ToString())] = true;
                }
            }

            Console.WriteLine(roomCount);
        }
    }
}