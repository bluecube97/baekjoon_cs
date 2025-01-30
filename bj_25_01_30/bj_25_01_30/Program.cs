internal class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            list.Add(int.Parse(Console.ReadLine()));
        }

        Console.WriteLine(list.Average());
        list.Sort();
        Console.WriteLine(list[2]);
    }
}