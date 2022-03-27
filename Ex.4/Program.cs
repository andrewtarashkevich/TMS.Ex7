using System;
using System.Collections.Generic;

namespace Ex._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1            
            int a1 = 120;
            ShowArray(GetNumbersUpTo1000(a1).ToArray());

            //Задание 2            
            int a2 = 12;
            ShowArray(GetSquareNumbers(a2).ToArray());

            //Задание 3
            int a3 = 45;
            int max_delimeter = MaxDelimeter(a3);
            Console.WriteLine(max_delimeter);

            //Задание 4            
            int a4 = 1;            
            int b4 = 13;
            int sum4 = SumAll7(a4,b4);
            Console.WriteLine(sum4);

            //Задание 5            
            int a5 = 78;           
            int b5 = 54;
            int max_divider = MaxDivider(a5,b5);
            Console.WriteLine(max_divider);

            //Задача 7            
            int a7 = 12345667;
            int sum7 = SumAllEven(a7);
            Console.WriteLine(sum7);

            //Задача 8            
            int a8 = 123;
            ReverseNumbers(ref a8);
            Console.WriteLine(a8);

        }
        static void ShowArray(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
        static List<int> GetNumbersUpTo1000(int a1)
        {
            List<int> nums = new List<int>();
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a1 == 0)
                    nums.Add(i);                
            }
            return nums;
        }
        static List<int> GetSquareNumbers(int a2)
        {
            List<int> nums = new List<int>();
            for (int i = 1; i <= Math.Pow(a2, 2); i++)
            {
                if (Math.Pow(i, 2) < a2)
                    nums.Add(i);
            }
            return nums;
        }
        static int MaxDelimeter(int a3)
        {
            int max_d3 = 0;            
            for (int i = 1; i < a3; i++)
            {
                if (a3 % i == 0)
                    max_d3 = i;
            }
            return max_d3;
        }
        static int SumAll7(int a4, int b4)
        {
            int sum4 = 0;
            for (int i = Math.Min(a4, b4); i <= Math.Max(a4, b4); i++)
            {
                if (i % 7 == 0)
                    sum4 += i;
            }
            return sum4;
        }
        static int MaxDivider(int a5, int b5)
        {
            int dividend5 = Math.Max(a5, b5);
            int divisor5 = Math.Min(a5, b5);
            int quotient5 = dividend5 / divisor5;
            int remainder5 = dividend5 - quotient5 * divisor5;
            do
            {
                dividend5 = divisor5;
                divisor5 = remainder5;
                quotient5 = dividend5 / divisor5;
                remainder5 = dividend5 - quotient5 * divisor5;

            } while (remainder5 != 0);
            return divisor5;
        }
        static int SumAllEven(int a7)
        {
            int b7 = a7;
            int sum7 = 0;
            while (b7 > 0)
            {
                if ((b7 % 10) % 2 == 0)
                    sum7 += 1;
                b7 = b7 / 10;
            }
            return sum7;
        }
        static void ReverseNumbers(ref int a8)
        {
            do
            {
                Console.Write(a8 % 10);
                a8 = a8 / 10;
            } while (a8 / 10 != 0);
           
        }
    }
}
