internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        int[] fceb = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int f = fceb[0]; // 밀가루
        int c = fceb[1]; // 초콜릿
        int e = fceb[2]; // 달걀
        int b = fceb[3]; // 버터

        int[] needFceb = isr.ReadLine().Split().Select(int.Parse).ToArray();
        int needF = needFceb[0]; // 밀가루 필요량
        int needC = needFceb[1]; // 초콜릿 필요량
        int needE = needFceb[2]; // 달걀 필요량
        int needB = needFceb[3]; // 버터 필요량

        int cookie = 0;
        int queryCount = int.Parse(isr.ReadLine());

        for (int j = 0; j < queryCount; j++)
        {
            int[] query = isr.ReadLine().Split().Select(int.Parse).ToArray();
            int program = query[0];
            int i = query[1];

            switch (program)
            {
                case 1:
                    if (f >= needF * i && c >= needC * i && e >= needE * i && b >= needB * i)
                    {
                        f -= needF * i;
                        c -= needC * i;
                        e -= needE * i;
                        b -= needB * i;
                        cookie += i;
                        Console.WriteLine(cookie);
                    }
                    else
                    {
                        Console.WriteLine("Hello, siumii");
                    }

                    break;
                case 2:
                    f += i;
                    Console.WriteLine(f);
                    break;
                case 3:
                    c += i;
                    Console.WriteLine(c);
                    break;
                case 4:
                    e += i;
                    Console.WriteLine(e);
                    break;
                case 5:
                    b += i;
                    Console.WriteLine(b);
                    break;
            }
        }
    }
}