internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int result = int.Parse(isr.ReadLine());
        while (true)
        {
            string oper = isr.ReadLine();

            if (oper == "=")
            {
                Console.WriteLine(result);
                break;
            }

            int num = int.Parse(isr.ReadLine());

            switch (oper)
            {
                case "+":
                    result += num;
                    break;
                case "-":
                    result -= num;
                    break;
                case "*":
                    result *= num;
                    break;
                case "/":
                    result /= num;
                    break;
            }
        }
    }
}