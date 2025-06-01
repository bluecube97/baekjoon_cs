internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] numArr = isr.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(numArr);

        int a = numArr[0];
        int b = numArr[1];
        int c = numArr[2];

        string command = isr.ReadLine();

        foreach (var ch in command)
        {
            if (ch == 'A')
            {
                Console.Write(a + " ");
            }
            else if (ch == 'B')
            {
                Console.Write(b + " ");
            }
            else if (ch == 'C')
            {
                Console.Write(c + " ");
            }
        }
    }
}