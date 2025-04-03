using System.Numerics;

internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] numArr = isr.ReadLine().Split().Select(int.Parse).ToArray();

        Array.Sort(numArr);
        Console.WriteLine(numArr[1]);
    }
}