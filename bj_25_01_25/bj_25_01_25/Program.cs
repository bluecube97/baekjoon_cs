internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length - 2; i++)
        {
            if (input[i] != null && input[i].Equals('P') && input[i + 1].Equals('S') && (input[i + 2].Equals('4') || input[i + 2].Equals('5')))
            {
                input = input.Remove(i + 2, 1);
                i--;
            }
        }

        Console.WriteLine(input);
    }
}