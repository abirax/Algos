using System;

namespace RotateA2DMatrix
{
    class Program
    {
        public static void Main()
        {
            int[,] matrix = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };

            PrintMatrix(matrix);
            RotateMatrix(matrix);
            PrintMatrix(matrix);

            Console.ReadLine();
        }
        private static void RotateMatrix(int[,] a)
        {
            int length = a.GetLength(0);
            for (int layer = 0; layer < length - 2; layer++)
            {

                int first = layer;
                int last = length - 1 - layer;
                int top;
                for (int i = first; i < last; i++)
                {

                    top = a[first, i];
                    a[first, i] = a[last - i, first];
                    a[last - i, first] = a[last, last - i];
                    a[last, last - i] = a[first, last - i];
                    a[i, last] = top;
                    //int offset = i - first;
                    //top = a[first, i];
                    //a[first, i] = a[last - offset, first];
                    //a[last - offset, first] = a[last, last - offset];
                    //a[last, last - offset] = a[i, last];
                    //a[i, last] = top;


                }

            }
        }
        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i,j].ToString());
                }
                Console.WriteLine();


            }


        }
    }
}
