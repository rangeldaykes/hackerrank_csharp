using System;
using System.Linq;

namespace Algorithms
{
    public class miniMaxSum
    {
        public string miniMaxSum_solution1(long[] ar)
        {
            Array.Sort(ar);
            long min = 0, max = 0;
            for (int i = 0; i < 4; i++)
            {
                min += ar[i];
                max += ar[i + 1];
            }

            //Console.WriteLine(min.ToString() + " " + max.ToString());
            return min.ToString() + "  " + max.ToString();
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
