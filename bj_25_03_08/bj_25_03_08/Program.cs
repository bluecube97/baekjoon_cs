internal class Program
{
    static void Main(string[] args)
    {
        var isr = new StreamReader(Console.OpenStandardInput());
        string[] input = isr.ReadLine().Split();

        for (int i = 0; i < input[0].Length; i++)
        {
            if (input[0][i] == '6')
            {
                input[0] = input[0].Remove(i, 1).Insert(i, "5");
            }
        }

        for (int i = 0; i < input[1].Length; i++)
        {
            if (input[1][i] == '6')
            {
                input[1] = input[1].Remove(i, 1).Insert(i, "5");
            }
        }

        Console.Write(int.Parse(input[0]) + int.Parse(input[1]) + " ");

        for (int i = 0; i < input[0].Length; i++)
        {
            if (input[0][i] == '5')
            {
                input[0] = input[0].Remove(i, 1).Insert(i, "6");
            }
        }

        for (int i = 0; i < input[1].Length; i++)
        {
            if (input[1][i] == '5')
            {
                input[1] = input[1].Remove(i, 1).Insert(i, "6");
            }
        }

        Console.Write(int.Parse(input[0]) + int.Parse(input[1]));
    }
}