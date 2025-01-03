internal class Program
{
    static void Main(string[] args)
    {
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        List<int> primes = GeneratePrimes(m, n);
        foreach (int prime in primes)
        {
            sum += prime;
        }

        if (primes.Count == 0)
        {
            Console.WriteLine(-1);
        }
        else
        {
            Console.WriteLine(sum);
            Console.WriteLine(primes[0]);
        }
    }

    static List<int> GeneratePrimes(int start, int end)
    {
        bool[] isPrime = new bool[end + 1];
        for (int i = 2; i <= end; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= end; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= end; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        List<int> primes = new List<int>();
        for (int i = Math.Max(start, 2); i <= end; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}