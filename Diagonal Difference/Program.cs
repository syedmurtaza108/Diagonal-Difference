/*
Given a square matrix, calculate the absolute difference between the sums of its diagonals.

Complete the diagonalDifference function which takes a 2D  integer array as a parameter and return an integer denoting the absolute difference between the diagonal sums.

Raw Input Format

The first line contains a single integer, n,  denoting the number of rows and columns in the matrix a. 
The next  lines denote the matrix a's rows, with each line containing n space-separated integers describing the columns.

Sample Input 0

3
11 2 4
4 5 6
10 8 -12
Sample Output 0

15
Explanation

The primary diagonal is:

11
   5
     -12
Sum across the primary diagonal: 11 + 5 - 12 = 4

The secondary diagonal is:

     4
   5
10
Sum across the secondary diagonal: 4 + 5 + 10 = 19 
Difference: |4 - 19| = 15

Note: |x| is the absolute value of x
*/

//FINISHED IT IN 20 MIN


using System;

namespace Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] a = new int[n][];

            for (int aRowItr = 0; aRowItr < n; aRowItr++)
            {
                a[aRowItr] = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));
            }

            int result = diagonalDifference(a);

            Console.WriteLine(result);
        }

        static int diagonalDifference(int[][] a)
        {
            int[] dia1 = new int[a.GetLength(0)];
            int[] dia2 = new int[a.GetLength(0)];

            int temp = a.GetLength(0) -1 ;
            for (int i = 0; i < dia1.Length; i++)
            {
                dia1[i] = a[i][i];
                dia2[i] = a[i][temp--];
            }

            int sum1 = 0;
            int sum2 = 0;

            foreach (int i in dia1)
                sum1 += i;

            foreach (int i in dia2)
                sum2 += i;

            return Math.Abs(sum1 - sum2);

        }
    }
}
