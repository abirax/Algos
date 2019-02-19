using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeSubString
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("input str");
                string inpStr = Console.ReadLine();
                StringChecker checker = new StringChecker();
                Console.WriteLine("longest sub palindrome is " + checker.LongestPalindrome(inpStr));
                Console.ReadLine();
            }
        }
    }
    public class StringChecker
    {
        private bool IsPaindrome(string checkStr)
        {
            for (int k = 0; k <= checkStr.Length - 1; k++)
                if (checkStr[k] == checkStr[checkStr.Length - 1 - k])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            return true;

        }
        public virtual string LongestPalindrome(string s)
        {

            char[] arrStr = s.ToCharArray();
            // int longPalinLegth = 0;
            List<string> palinList = new List<string>();
            //string longPalin = "";
            int palinStartPos = -1, palinEndPos = -1;
            //bool isPalin = false;
            for (int i = 0; i <= s.Length - 1; i++)
            {
                for (int j = s.Length - 1 - i; j > i; j--)
                    if (IsPaindrome(s.Substring(i, j)))

                    {
                        palinList.Add(s.Substring(i, j));
                    }



            }
            foreach (string str in palinList)
            {
                Console.WriteLine(str);

            }
            string lasrget = palinList.OrderByDescending(st => st.Length).First();

            return lasrget;

        }
    }
}
