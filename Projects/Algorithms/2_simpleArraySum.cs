using System;
using System.Linq;

namespace AllTest
{
    public class simpleArraySum
    {
        public void simpleArraySum_solution1()
        {
            var ar = new int[] { 1, 3, 5, 7, 9 };

            var sum = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                sum += ar[i];
            }
            
            System.Console.WriteLine(sum);
        }
    }
}
