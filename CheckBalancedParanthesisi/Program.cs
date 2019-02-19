using System;

namespace CheckBalancedParanthesisi
{
    class Program
    {
        static void Main(string[] args)
        {
            string str=Console.ReadLine();
            char[] chars = str.ToCharArray();
            int countSqBracket = 0;
            int countCurlyBracket = 0;
            int countParBracket = 0;

            foreach(char c in chars)
            {
                if(countSqBracket==0 && c==']')
                {
                    countSqBracket = 1;
                    break;
                }

                if (countCurlyBracket == 0 && c == '}')
                {
                    countCurlyBracket = 1;
                    break;
                }

                if (countParBracket == 0 && c == ')')
                {
                    countParBracket = 1;
                    break;
                }

                if (c == '[')
                    countSqBracket++;
                if (c == ']')
                    countSqBracket--;


                if (c == '(')
                    countParBracket++;
                if (c == ')')
                    countParBracket--;


                if (c == '{')
                    countCurlyBracket++;
                if (c == '}')
                    countCurlyBracket--;
            }
            if (countCurlyBracket != 0 || countParBracket != 0 || countSqBracket != 0)
                Console.WriteLine("false");
            Console.WriteLine("True");
            Console.ReadLine();
        }
    }
}
