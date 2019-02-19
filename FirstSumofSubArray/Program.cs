using System;

namespace FirstSumofSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("input sum and array");
                int sum = Int32.Parse(Console.ReadLine());
                string numStr = Console.ReadLine();
                int[] numbers = new int[numStr.Split(' ').Length];
                int counter = 0;
                string[] c = numStr.Split(' ');
                foreach (string s in c)
                {
                    numbers[counter] = Int32.Parse(s);
                    counter++;
                }
                FindSum(numbers, sum);
            }
        }
        static void FindSum(int[] nums, int sum)
        {
            int currSum = nums[0];
            int start = 0;
            for (int i = 1; i < nums.Length; i++)
            {
                currSum = nums[i] + currSum;
                if (currSum == sum)
                {
                    Console.WriteLine("sum is found pos {0} to {1}", start, i);
                    break;
                }
                while (currSum > sum && start<i-1)
                {
                    currSum = currSum - nums[start];
                    start++;
                }
            }
            Console.WriteLine("Couldnt find");
        }
    }
}
