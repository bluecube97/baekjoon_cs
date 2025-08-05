internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int n = int.Parse(isr.ReadLine());
        int[] arr = new int[n];

        arr[0] = 1;
        arr[1] = 2;

        for (int i = 2; i < n - 1; i++)
        {
            arr[i] = i + 1;
        }

        arr[n - 1] = 997;

        Console.WriteLine(n);
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i]);
            Console.Write(" ");
        }
    }
}