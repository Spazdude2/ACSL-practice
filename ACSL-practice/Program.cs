using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACSL_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int evenNums = 0;
            int oddNums = 0;
            int evenSum = 0;
            int oddSum = 0;

            Console.Write("Dice: ");
            int[] nums = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();

            for (int i = 0; i < 3; i++)
            {
               if(nums[i] % 2 == 0)
               {
                    evenNums++;
                    evenSum += nums[i];
               }

               else
               {
                    oddNums++;
                    oddSum += nums[i];
               }
            }


            Console.WriteLine("Profit: $" + ((evenSum * evenNums) + (oddSum * oddNums)));

        }
    }
}
