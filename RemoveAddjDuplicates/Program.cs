using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RemoveAddjDuplicates
{
    class Program
    {
        public static void Main()
        {
            string inputStr = "abccccbafg,hst";
            string myFinalStr = "";
            Console.WriteLine(inputStr);
            myFinalStr = RemoveDuplicateString(inputStr);
            Console.WriteLine(myFinalStr);
            Console.ReadLine();

        }
        public static string RemoveDuplicateString(string inputStr)
        {

            List<Char> charList = new List<char>();
            char[] charArr = inputStr.ToCharArray();
            for (int i = 0; i <= charArr.Length - 1; i++)

            {
                if (i != (charArr.Length - 1))
                {
                    if (charArr[i] == charArr[i + 1])
                        continue;
                }
                if(i!=0)
                { 
                    if (charArr[i] == charArr[i - 1])
                        continue;
                }
                charList.Add(charArr[i]);

            }
            StringBuilder str = new StringBuilder("");
            foreach (char c in charList)
                str = str.Append(c);

            string temp =str.ToString();
            if (CheckDuplicates(temp))
            {
                Console.WriteLine(temp);
               temp= RemoveDuplicateString(temp);
            }
            return temp;
        }
        public static bool CheckDuplicates(string checkStr)
        {
            char[] strChar = checkStr.ToCharArray();
            for (int i = 0; i <= checkStr.Length - 1; i++)
            {
                if(i!=(checkStr.Length-1))
                if (strChar[i] == strChar[i + 1])
                    return true;
            }
            return false;

        }
    }
}
