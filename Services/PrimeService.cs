using System;
using System.Collections.Generic;

namespace Swagger.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            for (var divisor = 2; divisor <= Math.Sqrt(candidate); divisor++)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }
            return true;
        }

		public IEnumerable<int> GeneratePrime(int toGenerate) {
			var primes = new List<int>();
			primes.Add(2);
			primes.Add(3);
			while (primes.Count < toGenerate)
			{
				int nextPrime = (int)(primes[primes.Count - 1]) + 2;
				while (true)
				{
					bool isPrime = true;
					foreach (int n in primes)
					{
						if (nextPrime % n == 0)
						{
							isPrime = false;
							break;
						}
					}
					if (isPrime)
					{
						break;
					}
					else
					{
						nextPrime += 2;
					}
				}
				primes.Add(nextPrime);
			}
			return primes;
		}
    }
}