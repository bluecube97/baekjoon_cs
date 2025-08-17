internal class Program
{
    static void Main()
    {
        var isr = new StreamReader(Console.OpenStandardInput());

        string[] phone = isr.ReadLine().Split().ToArray();
        string oldPhone = phone[0];
        string newPhone = phone[1] + oldPhone;

        int oldPhoneInt = int.Parse(oldPhone);
        int newPhoneInt = int.Parse(newPhone);

        if (isPrime(oldPhoneInt) && isPrime(newPhoneInt))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    private static bool isPrime(int num)
    {
        if (num % 2 == 0) return false;

        for (int i = 3; i * i <= num; i += 2)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}