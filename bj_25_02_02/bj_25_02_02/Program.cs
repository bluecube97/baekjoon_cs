internal class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 7; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 != 0)
            {
                list.Add(num);
            }
        }

        if (list.Count == 0)
        {
            Console.WriteLine(-1);
            return;
        }

        Console.WriteLine(list.Sum());
        Console.WriteLine(list.Min());
    }
}