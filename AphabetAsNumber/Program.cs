using System;
using System.Collections.Generic;

namespace AphabetAsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<char, int> number = new Dictionary<char, int>();
            number.Add('A', 1);
            number.Add('B', 2);
            number.Add('C', 3);
            number.Add('D', 4);
            number.Add('E', 5);
            number.Add('Z', 26);
            while (true)
            { 
            string str = Console.ReadLine();
            char[] chars = str.ToCharArray();
            
            double myValue= GetValue(chars,number);
            
            Console.WriteLine(myValue);

            }
        }

        static double GetValue(char[] chars,Dictionary<char,int> numberList)
        {
            int baseValueofChar = 0;
            double myValue = 0;
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                numberList.TryGetValue(chars[i], out baseValueofChar);
                myValue = myValue + Math.Pow(26,  (chars.Length - 1)-i)*baseValueofChar;
                                                   }
            return myValue;

        }
    }
}
