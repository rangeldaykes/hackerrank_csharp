using System;
using System.Linq;

namespace Algorithms
{
    public class simpleArraySum
    {
        public int simpleArraySum_solution1(int[] ar)
        {
            var sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            
            return sum;
        }
    }
}
