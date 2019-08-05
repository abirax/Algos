using System;

namespace SearchInRotatedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = Console.ReadLine().Split(' ');
            int[] numbers = { 7,8,9,1,2,3,4, 5, 6 };
            int key = 19;
            int pivot = FindPivot(numbers,0, numbers.Length-1);
            Console.WriteLine("pivot is "+pivot.ToString());
            if (key>numbers[numbers.Length-1])
            Console.WriteLine("Binary Search is " + BinarySearch(numbers,0,pivot,key).ToString());
            else
                Console.WriteLine("Binary Search is " + BinarySearch(numbers, pivot, numbers.Length-1, key).ToString());

            Console.ReadLine();
        }
        static int FindPivot(int[] arr,int start,int end)
        {
            int midPoint = Math.Abs((end + start) / 2);
            if (midPoint < 1|| midPoint>=arr.Length-1)
                return -1;

            if (arr[midPoint] > arr[midPoint + 1])
                return midPoint;
            else if (arr[midPoint - 1] > arr[midPoint])
                return midPoint - 1;
            else if ((midPoint + 1) == arr.Length - 1)
                return -1;
            else if (arr[start] < arr[midPoint])
                return FindPivot(arr, midPoint + 1, end);
            else
                return FindPivot(arr, start, midPoint);
         
            

        }
        static int BinarySearch(int[] arr,int start,int end,int key)
        {
            if (arr[end] < key)
                return -1;
            int mid = Math.Abs((start + end) / 2);
            if (arr[mid] == key)
                return mid;
            
            else if (arr[mid] > key)
                return (BinarySearch(arr, start, mid - 1, key));
            else
                return (BinarySearch(arr, mid+1, end, key));
        }
    }
}
