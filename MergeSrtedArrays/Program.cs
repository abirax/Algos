using System;
using System.Collections.Generic;

namespace MergeSrtedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello World! Enter the size of the arrays and then the actual 2 arrays");
                string[] lengths = Console.ReadLine().Split(' ');
                string[] aar1 = Console.ReadLine().Split(' ');
                string[] aar2 = Console.ReadLine().Split(' ');
                int[] num1 = new int[Int32.Parse(lengths[0])];
                int[] num2 = new int[Int32.Parse(lengths[1])];
                int counter = 0;
                foreach (string s in aar1)
                {
                    num1[counter] = Int32.Parse(s);
                    counter++;
                }
                counter = 0;
            foreach (string s in aar2)
                {
                    num2[counter] = Int32.Parse(s);
                    counter++;
                }
                int[] mergedArray = MergeArrays(num1, num2);
                foreach (int n in mergedArray)
                    Console.Write("{0} ", n.ToString());
            }
        }
        private static int[] MergeArrays(int[] arr1,int[] arr2)
        {
            int i = 0;
            int j = 0;
            int counter = 0;
            int[] mergedArray = new int[arr1.Length + arr2.Length];
            while(true)
            {
                if(arr1[i]>arr2[j])
                {
                    mergedArray[counter] = arr2[j];
                    j++;
                    counter++;
                }
                if (arr1[i] < arr2[j])
                {
                    mergedArray[counter] = arr1[i];
                    i++;
                    counter++;
                }
               
                if((j>arr2.Length-1))
                {
                    for (int counteri=i;counteri<=arr1.Length-1;counteri++)
                    {
                        mergedArray[counter] = arr1[counteri];
                        counter++;
                    }
                    break;


                }
                if ((i > arr1.Length - 1))
                {
                    for (int counteri = j; counteri <= arr2.Length - 1; counteri++)
                    {
                        mergedArray[counter] = arr2[counteri];
                        counter++;
                    }
                    break;


                }
                if (arr1[i] == arr2[j])
                {
                    mergedArray[counter] = arr1[i];
                    counter++;
                    i++;
                    j++;
                }
                if (counter == (mergedArray.Length - 1))
                    break;
            }
            return mergedArray;
        }
    }
}
