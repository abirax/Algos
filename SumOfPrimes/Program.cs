using System;
using System.Collections.Generic;

namespace SumOfPrimes
{
    class Program
    {
     
        static public void Main()
        {
            //Console.WriteLine("Hello World!") check;
            int numberOfTestCases = Int32.Parse(Console.ReadLine());
            int[] mySums = new int[numberOfTestCases];
            for (int k = 0; k < numberOfTestCases; k++)
            {
                List<int> primeNumbers = new List<int>();
                int number = Int32.Parse(Console.ReadLine());
                //for (int i = 2; i < number; i++)
                //    {
                //        bool isPrime = false;
                //        if (i == 2)
                //            isPrime=true;

                //        for (int j = 2; j < i; j++)
                //        {
                //            isPrime = true;
                //            if (i % j == 0)
                //            {
                //                isPrime = false;
                //                break;
                //            }


                //        }
                //        if (isPrime)
                //            primeNumbers.Add(i);
                //    }
                    int sumOfPrime = 0;
                primeNumbers = GetPrimeNumbers2(number);
                    foreach (int n in primeNumbers)
                    sumOfPrime = sumOfPrime + n;
                mySums[k]= sumOfPrime;
                //Console.WriteLine(sumOfPrime);
            }
            foreach (int sum in mySums)
                Console.WriteLine(sum);
            Console.ReadLine();
        }

        private static List<int> GetPrimeNumbers2(long number)
        {
            var result = new List<int>();

            for (var i = 2; i <= number; i++)
            {
                var isPrime = true;
                var n = Math.Floor(Math.Sqrt(i));

                for (var j = 2; j <= n; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    result.Add(i);
                }
            }

            return result;
        }
    }
}

