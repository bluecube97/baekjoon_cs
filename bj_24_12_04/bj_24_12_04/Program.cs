internal class Program
{
    static void Main(string[] args)
    {
        string jinho = Console.ReadLine();
        List<string> mbtiList = new List<string>();
        int n = int.Parse(Console.ReadLine());
        int count = 0;

        for (int i = 0; i < n; i++)
        {
            mbtiList.Add(Console.ReadLine());
        }

        foreach (var str in mbtiList)
        {
            if (jinho == str)
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}