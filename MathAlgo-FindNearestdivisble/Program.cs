using System;
using System.Collections;

namespace MathAlgo_FindNearestdivisble
{
    class Program
    {
        
            static public void Main()
            {
                //Console.WriteLine("Hello World!");
                int numberOfTestCases = Int32.Parse(Console.ReadLine());
                for (int k = 0; k < numberOfTestCases; k++)
                {
                string[] mystring = Console.ReadLine().Split(' ');
                    int n = Int32.Parse(mystring[0]);
                    
                    int m = Int32.Parse(mystring[1]);
                    int numberLessThanN = n;
                    int numberMoreThanN = n;
                    while (true)
                    {
                        if (numberLessThanN % m == 0)
                            break;
                        numberLessThanN--;
                    }
                    while (true)
                    {
                        if (numberMoreThanN % m == 0)
                            break;
                        numberMoreThanN++;

                }
                if (Math.Abs(numberMoreThanN - n) > Math.Abs(numberLessThanN - n))
                    Console.WriteLine(numberLessThanN);
                else
                    Console.WriteLine(numberMoreThanN);

                Console.ReadLine();
            }
            }
        }
    }
 
