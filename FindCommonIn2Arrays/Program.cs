using System;
using System.Collections.Generic;

namespace FindCommonIn2Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 3,45, 67, 98,189, 607,678, 999 };
            int[] b = { 3, 67, 76, 78, 98, 607, 678, 688 };
            List<int> myduplicates = new System.Collections.Generic.List<int>();

            int newposition = 0;
            for (int i=0;i<a.Length;i++)
            {
                for(int j =newposition;j<b.Length;j++)
                {
                   if(a[i]==b[j])
                    {
                        myduplicates.Add(a[i]);
                        newposition = j;
                        break;
                    }
                   if(a[i]<b[j])
                    {
                        newposition = j;
                        break;
                    }
                }

            }
            foreach (int x in myduplicates)
                Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
