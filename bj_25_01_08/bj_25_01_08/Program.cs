internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        int k = 1;
        char prev = 'a';
        prev--;

        foreach (var c in input)
        {
            if (c <= prev)
            {
                k++;
            }

            prev = c;
        }

        Console.Write(k);
    }
}