internal class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int info = input[0];
        int math = input[1];
        int science = input[2];
        int english = input[3];

        input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int info2 = input[0];
        int math2 = input[1];
        int science2 = input[2];
        int english2 = input[3];

        int S = info + math + science + english;
        int T = info2 + math2 + science2 + english2;

        Console.WriteLine(S >= T ? S : T);
    }
}