internal class Program
{
    static void Main(string[] args)
    {
        int V = int.Parse(Console.ReadLine());
        string vote = Console.ReadLine();

        int A = 0;
        int B = 0;

        foreach (char c in vote)
        {
            if (c == 'A')
            {
                A++;
            }
            else
            {
                B++;
            }
        }

        if (A > B)
        {
            Console.WriteLine("A");
        }
        else if (A < B)
        {
            Console.WriteLine("B");
        }
        else
        {
            Console.WriteLine("Tie");
        }
    }
}