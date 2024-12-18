internal class Program
{
    static void Main(string[] args)
    {
        var count = Console.ReadLine().Count(c => c is 'a' or 'e' or 'i' or 'o' or 'u');
        Console.WriteLine(count);
    }
}