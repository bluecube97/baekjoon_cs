internal class Program
{
    static void Main(string[] args)
    {
        int len = int.Parse(Console.ReadLine());
        string str = Console.ReadLine();

        int twoCount = 0;
        int eCount = 0;

        foreach (var c in str)
        {
            if (c == '2')
            {
                twoCount++;
            }
            else if (c == 'e')
            {
                eCount++;
            }
        }

        if (twoCount > eCount)
        {
            Console.WriteLine("2");
        }
        else if (twoCount < eCount)
        {
            Console.WriteLine("e");
        }
        else
        {
            Console.WriteLine("yee");
        }
    }
}