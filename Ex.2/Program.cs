using System;

namespace Ex._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1: Сумма чисел произвольного числа
            int orig = 1234;
            int sum = GetSumOfDigits(orig);
            Console.WriteLine($"Сумма цифр {orig} равна {sum}");

            //Задание 2            
            int x1 = 2;
            int y1 = 1;
            int radius = 4;
            bool shot_result = GetShotResult(x1,y1,radius);
            Console.WriteLine(shot_result);

            //Задание 3            
            int number = 755;
            bool digit_result = CompareMidDigit(number);          
            Console.WriteLine(digit_result);

            //Задание 4            
            int number_before_swap = 12345;
            int number_after_swap = SwapFirstAndLastDigits(number_before_swap);
            Console.WriteLine(number_after_swap);

            //Задание 5
            double number_double = 156.0;
            bool res = CompareFraction(number_double);
            Console.WriteLine(res);
        }
        private static int GetSumOfDigits(int orig)
        {
            int sum = 0;
            int temp = orig;
            for (int i = 0; i < orig.ToString().Length; i++)
            {
                sum += temp % 10;
                temp /= 10;
            }
            return sum;
        }

        private static bool GetShotResult(int x1, int y1, int radius)
        {
            return (Math.Pow(x1, 2) + Math.Pow(y1, 2)) >= Math.Pow(radius, 2);
        }

        private static bool CompareMidDigit(int number)
        {
            int first_digit = number / 100;
            int second_digit = number % 100 / 10;
            int third_digit = number % 10;
            return (second_digit <= first_digit && second_digit > third_digit);
        }

        private static int SwapFirstAndLastDigits(int number)
        {
            int[] array = new int[number.ToString().Length];
            for (int i = array.Length-1; i >= 0; i--)
            {
                array[i] = number % 10;
                number /= 10;
            }
            int[] new_array = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                new_array[i] = array[i];
            }
            new_array[0] = array[array.Length - 1];
            new_array[array.Length-1] = array[0];
            int number_after = 0;
            for (int i = 0; i < new_array.Length; i++)
            {
                number_after = number_after * 10 + new_array[i];
            }
            return number_after;
        }

        private static bool CompareFraction(double number_double)
        {
            int number_int = (int)number_double;
            bool res = true;
            return number_double < number_int;           
        }
    }
}
