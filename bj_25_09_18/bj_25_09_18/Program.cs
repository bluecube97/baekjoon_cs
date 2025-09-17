internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        char[] platformInit = isr.ReadLine().ToCharArray();
        bool isSubName = false;
        string platformName = "";
        string platformSubName = "";

        for (int i = 0; i < platformInit.Length; i++)
        {
            if (platformInit[i] == '(')
            {
                isSubName = true;
                platformName = new string(platformInit, 0, i - 1);
                platformSubName = new string(platformInit, i, platformInit.Length - i);
            }
        }

        if (!isSubName)
        {
            platformName = new string(platformInit);
        }

        string[] platform = platformSubName.Split().ToArray();

        Console.WriteLine(platformName);

        if (platformSubName == "")
        {
            Console.WriteLine("-");
        }
        else
        {
            for (int i = 0; i < platform.Length; i++)
            {
                string writeStr = platform[i];
                if (i == 0) writeStr = writeStr[1..];
                if (i == platform.Length - 1) writeStr = writeStr[..^1];
                Console.Write(writeStr);
                if (i != platform.Length - 1) Console.Write(" ");
                else Console.WriteLine();
            }
        }
    }
}