using System;
using System.Collections.Generic;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int sum = 0;
            int firstDia = 0, secDia=0;

            for (int i = 0; i < arr.Count; i++)
            {
                var list = arr[i];
                firstDia += list[i];

            }

            for (int i = 0; i <arr.Count ; i++)
            {
                var list = arr[i];
                secDia += list[arr.Count-1-i];

            }

            sum = Math.Abs((firstDia - secDia));

            return sum;

        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);

            Console.WriteLine(result);
        }
    }
}
