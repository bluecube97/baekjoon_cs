internal class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int result = NextYear(N);
        Console.WriteLine(result);
    }

    static int NextYear(int N)
    {
        List<int> primes = GeneratePrimes(10000);
        for (int i = 0; i < primes.Count - 1; i++)
        {
            int specialYear = primes[i] * primes[i + 1];
            if (specialYear > N)
            {
                return specialYear;
            }
        }
        return -1;
    }

    static List<int> GeneratePrimes(int limit)
    {
        bool[] isPrime = new bool[limit + 1];
        for (int i = 2; i <= limit; i++)
        {
            isPrime[i] = true;
        }

        for (int i = 2; i * i <= limit; i++)
        {
            if (isPrime[i])
            {
                for (int j = i * i; j <= limit; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        List<int> primes = new List<int>();
        for (int i = 2; i <= limit; i++)
        {
            if (isPrime[i])
            {
                primes.Add(i);
            }
        }

        return primes;
    }
}