using System;

internal class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());

        Console.WriteLine(N == 2 ? 3 : N);
    }
}