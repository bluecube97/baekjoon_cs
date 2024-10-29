internal class Program
{
    static void Main(string[] args)
    {
        int k = int.Parse(Console.ReadLine());

        for (int i = 0; i < k; i++)
        {
            int head = int.Parse(Console.ReadLine());
            string behavior = Console.ReadLine();
            int behaivorCount = behavior.Length;

            for (int j = 0; j < behaivorCount; j++)
            {
                if (head == 0)
                {
                    break;
                }
                if (behavior[j] == 'c')
                {
                    head++;
                }
                else if (behavior[j] == 'b')
                {
                    head--;
                }
            }
            Console.WriteLine("Data Set " + (i + 1) + ":");
            Console.WriteLine(head);
            Console.WriteLine();
        }
    }
}