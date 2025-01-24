internal class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        List<(string, string[])> songData = new List<(string, string[])>();

        for (int i = 0; i < n; i++)
        {
            input = Console.ReadLine().Split();
            int t = int.Parse(input[0]);
            string title = input[1];
            string[] a = new string[3];

            for (int j = 0; j < 3; j++)
            {
                a[j] = input[j + 2];
            }

            songData.Add((title, a));
        }

        for (int i = 0; i < m; i++)
        {
            string[] b = Console.ReadLine().Split();
            int sameCount = 0;
            string title = "";

            for (int j = 0; j < n; j++)
            {
                if (songData[j].Item2.SequenceEqual(b))
                {
                    sameCount++;
                    title = songData[j].Item1;
                }
            }

            if (sameCount == 1)
            {
                Console.WriteLine(title);
            }
            else if (sameCount == 0)
            {
                Console.WriteLine("!");
            }
            else
            {
                Console.WriteLine("?");
            }
        }
    }
}