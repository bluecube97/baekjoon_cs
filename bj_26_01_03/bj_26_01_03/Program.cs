internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int t = int.Parse(isr.ReadLine());

        for (int i = 0; i < t; i++)
        {
            string[] input = isr.ReadLine().Split();
            string s = input[0];
            int n = int.Parse(input[1]);

            int col1 = s[0] - 'A' + 1;
            int row1 = s[1] - '0';

            int row2 = (n - 1) / 8 + 1;
            int col2 = (n - 1) % 8 + 1;

            bool color1 = (row1 + col1) % 2 == 0;
            bool color2 = (row2 + col2) % 2 == 0;

            Console.WriteLine(color1 == color2 ? "YES" : "NO");
        }
    }
}