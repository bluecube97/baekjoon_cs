internal class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        string S = Console.ReadLine();

        char[] str = new char[27];

        for (int i = 0; i < N; i++)
        {
            str[S[i] - 'A' + 1]++;
        }

        int H = str[8];
        int I = str[9];
        int A = str[1];
        int R = str[18];
        int C = str[3];

        int min = Math.Min(H, Math.Min(I, Math.Min(A, Math.Min(R, C))));
        Console.WriteLine(min);
    }
}