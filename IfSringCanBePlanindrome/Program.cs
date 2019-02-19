using System;
using System.Collections;
using System.Collections.Generic;

namespace IfSringCanBePlanindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            while (true)
            {
                string checkStr = Console.ReadLine();

                Dictionary<char, int> occurance = new Dictionary<char, int>();
                foreach (Char c in checkStr)
                {
                    if(!c.Equals(' '))
                    
                    if (occurance.ContainsKey(c))
                    {
                        occurance[c] = (int)occurance[c] + 1;
                    }
                    else
                        occurance.Add(c, 1);
                }
                int moreThanOnce = 0;
                foreach (int values in occurance.Values)
                {
                    if (values % 2 != 0)
                    {
                        moreThanOnce++;

                    }
                }
                if (moreThanOnce > 1)
                    Console.WriteLine(" string combination cannot be palindrom");
                else
                    Console.WriteLine("string can be a palindrome");

                Console.ReadLine();
            }
        }
    }
}
