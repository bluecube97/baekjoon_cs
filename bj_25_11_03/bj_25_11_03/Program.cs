internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        isr.ReadLine();
        int problemCount = 0;

        while (true)
        {
            string query = isr.ReadLine();
            switch (query)
            {
                case "고무오리":
                    if (problemCount == 0)
                        problemCount += 2;
                    else
                        problemCount--;
                    break;
                case "문제":
                    problemCount++;
                    break;
                case "고무오리 디버깅 끝":
                    Console.WriteLine(problemCount == 0 ? "고무오리야 사랑해" : "힝구");
                    return;
            }
        }
    }
}