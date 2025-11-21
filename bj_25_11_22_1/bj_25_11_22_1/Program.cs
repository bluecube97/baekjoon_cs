internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        while (true)
        {
            string[] input = isr.ReadLine().Split().ToArray();
            if (input[0].Equals("*")) break;
            bool isTrue = true;

            char first = char.ToUpper(input[0][0]);

            foreach (var s in input)
            {
                if (!char.ToUpper(s[0]).Equals(first))
                {
                    Console.WriteLine("N");
                    isTrue = false;
                    break;
                }
            }

            if (isTrue) Console.WriteLine("Y");
        }
    }
}