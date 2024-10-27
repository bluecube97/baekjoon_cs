internal class Program
{
    static void Main(string[] args)
    {
        int round = int.Parse(Console.ReadLine());

        int changtotal = 100;
        int sangtotal = 100;

        for (int i = 0; i < round; i++)
        {
            string[] input = Console.ReadLine().Split(' ');

            int chang = int.Parse(input[0]);
            int sang = int.Parse(input[1]);

            if (chang > sang)
            {
                sangtotal -= chang;
            }
            else if (chang < sang)
            {
                changtotal -= sang;
            }
        }

        Console.WriteLine(changtotal);
        Console.WriteLine(sangtotal);
    }
}