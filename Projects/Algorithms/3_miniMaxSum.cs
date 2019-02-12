using System;
using System.Linq;

namespace AllTest
{
    public class miniMaxSum
    {
        public void miniMaxSum_solution1()
        {
            var arr = new long[] { 1, 3, 5, 7, 9 };

            Array.Sort(arr);
            long min = 0, max = 0;
            for (int i = 0; i < 4; i++)
            {
                min += arr[i];
                max += arr[i + 1];
            }

            Console.WriteLine(min.ToString() + " " + max.ToString());
        }

        public void miniMaxSum_solution2()
        {
            var arr = new long[] { 1, 3, 5, 7, 9 };

            long sum = arr.Sum(x => (long)x);
            long min = sum - arr.Max();
            long max = sum - arr.Min();

            Console.WriteLine(min.ToString() + " " + max.ToString());
        }
    }
}
