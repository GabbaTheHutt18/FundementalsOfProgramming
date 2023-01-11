using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TimeLibrary
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Stopwatch stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            List<int> num1 = GetPrimesV1(100000);
            stopwatch1.Stop();
            TimeSpan ts1 = stopwatch1.Elapsed;
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            List<int> num2 = GetPrimesV2(100000);
            stopwatch2.Stop();
            TimeSpan ts2 = stopwatch2.Elapsed;
            Console.WriteLine($"{ts1}, {ts2}");

        }

        static List<int> GetPrimesV1(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (IsPrimeV1(i))
                    primes.Add(i);
            }
            return primes;
        }

        static List<int> GetPrimesV2(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 0; i < n; i++)
            {
                if (IsPrimeV2(i))
                    primes.Add(i);
            }
            return primes;
        }

        static bool IsPrimeV1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if (i * i == n)
                    return true;
            }
            return false;
        }

        static bool IsPrimeV2(int n)
        {
            var limit = Math.Sqrt(n);
            for (int i = 0; i < limit; i++)
            {
                if (i * i == n)
                    return true;
            }
            return false;
        }
    }
}

