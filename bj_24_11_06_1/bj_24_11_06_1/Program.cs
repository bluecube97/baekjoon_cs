﻿internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        Console.WriteLine(result);
    }
}