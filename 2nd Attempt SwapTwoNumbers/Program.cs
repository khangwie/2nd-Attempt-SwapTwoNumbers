using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_Attempt_SwapTwoNumbers
{
    public class Program
    {
          public static void Main(string[] args)
        {
            int aNum = 87;
            int bNum = 45;
            SwapTwoNumbers(aNum, bNum);
            Console.ReadLine();
        }
        private static void SwapTwoNumbers(int aNum, int bNum)
        { 
             int temp = aNum;
            aNum = bNum;
            bNum = temp;

            Console.WriteLine($"Before: a = {bNum}, b = {aNum}");
            Console.WriteLine($"After: a = {aNum}, b = {bNum}");
        }
    }
}
