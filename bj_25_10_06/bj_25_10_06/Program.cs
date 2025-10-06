internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] nm = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int n = nm[0];
        int m = nm[1];

        bool[][] isPatrol = new bool[n][];

        for (int i = 0; i < n; i++)
        {
            string patrol = isr.ReadLine();
            isPatrol[i] = new bool[m];
            for (int j = 0; j < m; j++)
            {
                isPatrol[i][j] = patrol[j] == 'O';
            }
        }

        for (int i = 0; i < m; i++)
        {
            bool canEscape = true;

            for (int j = 0; j < n; j++)
            {
                if (isPatrol[j][i])
                {
                    canEscape = false;
                    break;
                }
            }

            if (canEscape)
            {
                Console.WriteLine(i + 1);
                return;
            }
        }

        Console.WriteLine("ESCAPE FAILED");
    }
}