using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveDuplicatesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 5, 1, 7, 2, 4, 2 };
            
         
            
            RemoveDuplicatesUsingLinq(arr);
            RemoveDuplicatesUsingLinqMethod(arr);
            RemoveDuplicatesUsingHashSet(arr);
            Console.ReadLine();
        }
        private static void RemoveDuplicatesUsingLinq(int[] origArr)
        {
            var noDuplicates = (from num in origArr
                               select num).Distinct();
            foreach (var num in noDuplicates)
                Console.WriteLine(num);

        }

        private static void RemoveDuplicatesUsingLinqMethod(int[] origArr)
        {
            var noDuplicates = origArr.Distinct();
            foreach (var num in noDuplicates)
                Console.WriteLine(num);

        }

        private static void RemoveDuplicatesUsingHashSet(int[] origArr)
        {
            HashSet<int> nonDuplicates = new HashSet<int>();
            foreach (int n in origArr)
            {
                try
                {
                    if (!nonDuplicates.Contains(n))
                        nonDuplicates.Add(n);

                }
                catch { }

            }
            foreach (int n in nonDuplicates)
                Console.WriteLine("numbers +" + n);

        }
    }
}
