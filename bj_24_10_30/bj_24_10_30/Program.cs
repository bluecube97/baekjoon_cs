internal class Program
{
    static void Main(string[] args)
    {
        int card = 0;

        for (int i = 0; i < 5; i++)
        {
            card += int.Parse(Console.ReadLine());
        }

        Console.WriteLine(card);
    }
}